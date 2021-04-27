using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double total;
            char sign;

            Console.WriteLine("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор (+, -, *,/): ");
            sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            b = Convert.ToDouble(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    total = a + b;
                    Console.WriteLine("Ответ: " + total);
                    break;
                case '-':
                    total = a - b;
                    Console.WriteLine("Ответ: " + total);
                    break;
                case '*':
                    total = a * b;
                    Console.WriteLine("Ответ: " + total);
                    break;
                case '/':
                    total = a / b;
                    Console.WriteLine("Ответ: " + total);
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор"); break;
            }

        }
    }
}

