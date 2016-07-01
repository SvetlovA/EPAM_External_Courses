using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int sum = 0;
            while (N < 1000)
            {
                if (N % 3 == 0 || N % 5 == 0)
                {
                    sum += N;   
                }
                N++;
            }
            Console.WriteLine("Сумма чисел меньше 1000, кратных 3, или 5: {0}", sum);
            Console.ReadKey();
        }
    }
}
