using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Введите пять чисел");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}-е число: ", i + 1);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int newper;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        newper = arr[i];
                        arr[i] = arr[j];
                        arr[j] = newper;
                    }
                }
            }

            Console.WriteLine("Вывод массива");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}