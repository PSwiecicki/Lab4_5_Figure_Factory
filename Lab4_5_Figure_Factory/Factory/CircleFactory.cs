﻿using System;
using System.Collections.Generic;
using System.Text;
using Lab4_5_Figure_Factory.Class;

namespace Lab4_5_Figure_Factory.Factory
{
    class CircleFactory : FigureFactory
    {
        public override IFigure Create()
        {
            Random rand = new Random();
            return new Circle((0.1 + rand.NextDouble()) * rand.Next(1, 101));
        }

        public IFigure Create(double r)
        {
            return new Circle(r);
        }
    }
}
