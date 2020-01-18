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
}
