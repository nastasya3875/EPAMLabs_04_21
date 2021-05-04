using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure F1, F2, F3;

            try
            {
                Console.WriteLine("a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("c = ");
                int c = int.Parse(Console.ReadLine());

                F1 = new Rectangle(a, b);
                F2 = new Square(a);
                F3 = new Triangle(a, b, c);


                Console.WriteLine("Периметр и площадь прямоугольника " + F1.Perimeter() + ", " + F1.Ploshad());
                Console.WriteLine("Периметр и площадь квадрата " + F2.Perimeter() + ", " + F2.Ploshad());
                Console.WriteLine("Периметр и площадь треугольника " + F3.Perimeter() + ", " + F3.Ploshad());

                Console.ReadLine();


                List<Rectangle> x = new List<Rectangle>();

                x.Add(new Rectangle(a, b) { number = 1, color = "red" });
                x.Add(new Rectangle(a, b) { number = 5, color = "red" });
                x.Add(new Rectangle(a, b) { number = 7, color = "blue" });
                x.Add(new Rectangle(a, b) { number = 3, color = "yellow" });


                // List<Rectangle> x1 = x.Where(x => x.color == "red").ToList();


                var sortedRectangles = from temp in x
                                       orderby temp.number
                                       select temp;

                foreach (Rectangle temp in sortedRectangles)
                    Console.WriteLine(temp.number);

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Возникло исключение: {e.Message}");
            }
        }
    }
}
