﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_5_Figure_Factory.Class
{
    class Square : IFigure
    {
        //Constructors
        public Square(double a)
        {
            side = a;
        }

        //Fields
        private readonly double side;

        //Properties
        public double Perimeter { get { return side * 4; } }
        public double Field { get { return side * side; } }

        //Methods
        public override string ToString()
        {
            return String.Format("Kwadrat: {0}", side);
        }
    }
}
