using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Console.WriteLine("Во введенной строке время встречается {0} раз.", GetTimeCount(Console.ReadLine()));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Получение количество вхождений времени
        /// </summary>
        /// <param name="parInputString"> Входная строка</param>
        /// <returns> Количество вхождений</returns>
        static int GetTimeCount(string parInputString)
        {
            int timecount = 0;
            string pattern = @"[0-9]+:[0-9]+";
            foreach (var item in Regex.Matches(parInputString, pattern))
            {
                string[] time = item.ToString().Split(':');
                if (Convert.ToInt32(time[0]) < 24 && Convert.ToInt32(time[1]) < 60)
                {
                    timecount++;
                }
            }
            return timecount;
        }
    }
}
