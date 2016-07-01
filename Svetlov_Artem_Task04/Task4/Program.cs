using System;
using System.Text;
using System.Diagnostics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = Stopwatch.StartNew();
            Console.WriteLine("Время выплнения String при 10000 итераций = {0}мс.", Convert.ToString(GetStringTime()));
            Console.WriteLine("Время выплнения StringBuilder при 10000000 итераций = {0}мс.", Convert.ToString(GetStringBuilderTime()));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Получение времени работы String
        /// </summary>
        /// <returns> Время работы</returns>
        static long GetStringTime()
        {
            string str = "";
            int N = 100000;

            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Получение времени работы StringBuilder
        /// </summary>
        /// <returns> Время работы</returns>
        static long GetStringBuilderTime()
        {
            StringBuilder sb = new StringBuilder();
            int N = 10000000;

            Stopwatch watch = Stopwatch.StartNew();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
