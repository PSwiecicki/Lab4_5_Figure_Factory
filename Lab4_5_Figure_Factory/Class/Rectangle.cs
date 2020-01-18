﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_5_Figure_Factory.Class
{
    class Rectangle : IFigure
    {
        //Constructors
        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        //Fields
        private readonly double sideA;
        private readonly double sideB;

        //Properties
        public double Perimeter { get { return (sideA + sideB) * 2; } }
        public double Field { get { return sideA * sideB; } }

        //Methods
        public override string ToString()
        {
            return String.Format("Prostokąt: {0}, {1}", sideA, sideB);
        }
    }
}
