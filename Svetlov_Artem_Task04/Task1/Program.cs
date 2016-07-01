using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Console.WriteLine("Среднее количество слов в словах: {0}", Convert.ToString(AverageLength(Console.ReadLine())));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Определение средней длины слова в строке
        /// </summary>
        /// <param name="parInputString"> Входная строка</param>
        /// <returns> Средняя длина слова</returns>
        static double AverageLength(string parInputString)
        {
            int CountOfWords = 0;
            int CountOfSymbols = 0;
            foreach (var symbol in parInputString)
            {
                if (char.IsSeparator(symbol))
                {
                    CountOfWords++;
                }
                else
                {
                    if (!char.IsPunctuation(symbol))
                    {
                        CountOfSymbols++;
                    }
                }
            }
            return (double)CountOfSymbols / (CountOfWords + 1);
        }
    }
}
