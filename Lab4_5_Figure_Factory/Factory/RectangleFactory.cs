using System;
using System.Collections.Generic;
using System.Text;
using Lab4_5_Figure_Factory.Class;

namespace Lab4_5_Figure_Factory.Factory
{
    class RectangleFactory : FigureFactory
    {
        public override IFigure Create()
        {
            Random rand = new Random();
            return new Rectangle((0.1 + rand.NextDouble()) * rand.Next(1, 11), (0.1 + rand.NextDouble()) * rand.Next(1, 11));
        }

        public IFigure Create(double a, double b)
        {
            return new Rectangle(a, b);
        }
    }
}
