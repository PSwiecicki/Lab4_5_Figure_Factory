using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_5_Figure_Factory.Class
{
    class Circle : IFigure
    {
        //Constructors
        public Circle(double a)
        {
            radius = a;
        }

        //Fields
        private readonly double radius;

        //Properties
        public double Perimeter { get { return 2 * Math.PI * radius; } }
        public double Field { get { return Math.PI * radius * radius; } }

        //Methods
        public override string ToString()
        {
            return String.Format("Koło: {0}", radius);
        }
    }
}
