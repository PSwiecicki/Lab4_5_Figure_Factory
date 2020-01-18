using System;
using System.Collections.Generic;
using Lab4_5_Figure_Factory.Class;

namespace Lab4_5_Figure_Factory
{
    class Program
    {
        static void Main()
        {
            Figure factory = new Figure();
            Random rand = new Random();
            List<IFigure> figures = new List<IFigure>();
            bool finish = false;
            for (int i = 0; i <5; i++)
                figures.Add(factory.Create((Dict)rand.Next(0, 3)));
            do
            {
                Console.WriteLine("1. Wyświetl figury.");
                Console.WriteLine("2. Dodaj figurę");
                Console.WriteLine("K. Wyjdź");
                string choice;
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "K":
                        finish = true;
                        break;
                }
            }
            while (!finish);

            figures[1].Increase();
            Console.WriteLine(figures[1].ToString());
        }
    }
}
