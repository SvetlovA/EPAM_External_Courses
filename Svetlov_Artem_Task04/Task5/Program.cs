using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите HTML текст для обработки: ");
            string _html = Console.ReadLine();
            Console.Write("Результат замены \"<...>\" на \"_\": {0}", ChangeSymbols(_html));
            Console.WriteLine("\nНажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Замена символов в строке
        /// </summary>
        /// <param name="parInputString"> Входная строка</param>
        /// <returns> Строка после замены</returns>
        static string ChangeSymbols(string parInputString)
        {
            string pattern = @"<[\s\S]+?>";
            return Regex.Replace(parInputString, pattern, "_");
        }
    }
}
