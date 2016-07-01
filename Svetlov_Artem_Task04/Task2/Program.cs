using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string _firstStr = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string _secondStr = Console.ReadLine();
            Console.WriteLine("Полученая строка: {0}", Doubling(_firstStr, _secondStr));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Удвоение повторяющихся символов
        /// </summary>
        /// <param name="parStr"> Первая входная строка</param>
        /// <param name="parSecondStr"> Вторая входная строка</param>
        /// <returns> Строка с удвоенными повторяющимися символами</returns>
        static string Doubling(string parStr, string parSecondStr)
        {
            char[] symbols = parStr.ToCharArray();
            string str = string.Empty;
            for (int i = 0; i < parStr.Length; i++)
            {
                for (int j = 0; j < parSecondStr.Length; j++)
                {
                    if (parStr[i] == parSecondStr[j])
                    {
                        str += parStr[i];
                        break;
                    }
                }
                str += parStr[i];
            }
            return str;
        }
    }
}
