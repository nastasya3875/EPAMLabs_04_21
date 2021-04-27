using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure F1, F2, F3;

            Console.WriteLine("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            F1 = new Rectangle(a, b);
            F2 = new Square(a);
            F3 = new Triangle(a, b, c);

            Console.WriteLine("Периметр и площадь прямоугольника " + F1.Perimeter() + ", " + F1.Ploshad());
            Console.WriteLine("Периметр и площадь квадрата " + F2.Perimeter() + ", " + F2.Ploshad());
            Console.WriteLine("Периметр и площадь треугольника " + F3.Perimeter() + ", " + F3.Ploshad());

            Console.ReadLine();
        }
    }
}
