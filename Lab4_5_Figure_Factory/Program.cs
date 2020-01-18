using System;
using System.Collections.Generic;
using Lab4_5_Figure_Factory.Class;
using Lab4_5_Figure_Factory.Factory;

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
                Console.WriteLine("2. Dodaj figurę.");
                Console.WriteLine("K. Wyjdź.");
                string choice;
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Aby zwiększyc, zmniejszyć lub usunąć figurę wybierz ją po numerze.");
                            for (int i = 0; i < figures.Count; i++)
                                Console.WriteLine("{0}. {1}", i + 1, figures[i].ToString());
                            Console.WriteLine("K. Wróć.");
                            choice = Console.ReadLine();
                            if (choice == "K" || choice == "k")
                            {
                                finish = true;
                                Console.Clear();
                            }
                            else
                            {
                                try
                                {
                                    int index = Convert.ToInt32(choice)-1;
                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine(figures[index].ToString());
                                        Console.WriteLine("1. Powiększ.");
                                        Console.WriteLine("2. Zmniejsz.");
                                        Console.WriteLine("3. Usuń.");
                                        Console.WriteLine("K. Wróć.");
                                        choice = Console.ReadLine();
                                        Console.Clear();
                                        switch (choice)
                                        {
                                            case "1":
                                                figures[index].Increase();
                                                break;
                                            case "2":
                                                figures[index].Decrease();
                                                break;
                                            case "3":
                                                figures.RemoveAt(index);
                                                finish = true;
                                                break;
                                            case "k":
                                            case "K":
                                                finish = true;
                                                break;
                                            default:
                                                Console.WriteLine("Zła wartość. Wpisz ponownie.");
                                                break;
                                        }
                                    }
                                    while (!finish);
                                    finish = false;

                                }
                                catch
                                {
                                    Console.Clear();
                                    Console.WriteLine("Zła wartość. Podaj ponownie.");
                                }   
                            }
                        }
                        while (!finish);
                        finish = false;
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("Wybierz jaką figurę tworzysz:");
                            Console.WriteLine("1. Kwadrat.");
                            Console.WriteLine("2. Prostokąt.");
                            Console.WriteLine("3. Koło.");
                            Console.WriteLine("K. Wróć.");
                            choice = Console.ReadLine();
                            Console.Clear();
                            double a, b;
                            switch (choice)
                            {
                                case "1":
                                    SquareFactory squareFactory = new SquareFactory();
                                    Console.WriteLine("Podaj długość boku. ");
                                    a = Convert.ToDouble(Console.ReadLine());
                                    figures.Add(squareFactory.Create(a));
                                    break;
                                case "2":
                                    RectangleFactory rectangleFactory = new RectangleFactory();
                                    Console.WriteLine("Podaj długość pierwszego boku. ");
                                    a = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Podaj długość drugiego boku. ");
                                    b = Convert.ToDouble(Console.ReadLine());
                                    figures.Add(rectangleFactory.Create(a, b));
                                    break;
                                case "3":
                                    CircleFactory circleFactory = new CircleFactory();
                                    Console.WriteLine("Podaj długość promienia. ");
                                    a = Convert.ToDouble(Console.ReadLine());
                                    figures.Add(circleFactory.Create(a));
                                    break;
                                case "k":
                                case "K":
                                    finish = true;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Zły wybór. Wybierz ponownie.");
                                    break;
                            }
                        }
                        while (!finish);
                        finish = false;
                        Console.Clear();
                        break;
                    case "k":
                    case "K":
                        finish = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Zły wybór. Wybierz ponownie.");
                        break;
                }
            }
            while (!finish);
        }
    }
}
