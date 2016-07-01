using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество треугольников: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int k = 0; k < N; k++)
            {
                string stars = "*";
                string triangle = "";
                for (int i = 0; i < N - (N - 1 - k); i++)
                {
                    string spaсes = "";
                    for (int j = 0; j < N - i; j++)
                    {
                        spaсes += " ";
                    }
                    triangle = spaсes + stars;
                    Console.WriteLine(triangle);
                    stars += "**";
                }
            }
            Console.ReadKey();
        }
    }
}
