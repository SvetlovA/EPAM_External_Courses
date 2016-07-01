using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            Console.WriteLine(GetFormat(Console.ReadLine().Replace('.', ',')));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Получение нотации написанного числа
        /// </summary>
        /// <param name="parInputString"> Входная строка</param>
        /// <returns> Отображение нотации</returns>
        static string GetFormat(string parInputString)
        {
            double res;
            if (double.TryParse(parInputString, out res))
            {
                foreach (var symbol in parInputString)
                {
                    if (symbol == 'e' || symbol == 'E')
                    {
                        return "Это число в научной нотации";
                    }
                }
                return "Это число в обычной нотации";
            }
            else
            {
                return "Это не число";
            }
        }
    }
}
