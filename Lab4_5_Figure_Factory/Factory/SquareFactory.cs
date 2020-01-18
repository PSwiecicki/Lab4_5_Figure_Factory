using System;
using System.Collections.Generic;
using System.Text;
using Lab4_5_Figure_Factory.Class;

namespace Lab4_5_Figure_Factory.Factory
{
    class SquareFactory : FigureFactory
    {
        public override IFigure Create()
        {
            Random rand = new Random();
            return new Square((0.1 + rand.NextDouble()) * rand.Next(1, 11));
        }

        public IFigure Create(double a)
        {
            return new Square(a);
        }
    }
}
