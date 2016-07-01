using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int N = Convert.ToInt32(Console.ReadLine());
            string stars = "*";
            string triangle = "";
            for (int i = 0; i < N; i++)
            {
                string spaces = "";
                for (int j = 0; j < N - i; j++)
                {
                    spaces += " ";
                }
                triangle = spaces + stars;
                Console.WriteLine(triangle);
                stars += "**";
            }
            Console.ReadKey();
        }
    }
}
