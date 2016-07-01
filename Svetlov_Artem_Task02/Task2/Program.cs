using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string stars = "*";
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(stars);
                stars += "*";
            }
            Console.ReadKey();
        }
    }
}
