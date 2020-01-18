using System;

namespace Lab4_5_Figure_Factory
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Square
    {
        //Constructors
        public Square(double a)
        {
           side = a;
        }

        //Fields
        private double side;

        //Properties
        public double perimeter { get { return side * 4; } }
        public double field { get { return side * side; } }

        //Methods
        public override string ToString()
        {
            return String.Format("Kwadrat: {0}", side); 
        }
    }

    class Rectangle
    {
        //Constructors
        public Rectangle(double a, double  b)
        {
            sideA = a;
            sideB = b;
        }

        //Fields
        private double sideA;
        private double sideB;

        //Properties
        public double perimeter { get { return (sideA + sideB) * 2; } }
        public double field { get { return sideA * sideB; } }

        //Methods
        public override string ToString()
        {
            return String.Format("Prostokąt: {0}, {1}", sideA, sideB);
        }
    }
}
