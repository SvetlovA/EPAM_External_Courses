using System;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime _date = DateTime.Now;
            double _number = 3223421.14324251;

            Console.WriteLine("Форматы отображения даты и времени:");
            Console.WriteLine("{0, -18}{1}", "en", "ru");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_date, CultureInfo.CreateSpecificCulture("ru-RU")), 
                MakeOutputFormat(_date, CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("{0, -18}{1}", "en", "invariant");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_date, CultureInfo.CreateSpecificCulture("en-US")), 
                MakeOutputFormat(_date, CultureInfo.InvariantCulture));
            Console.WriteLine("{0, -18}{1}", "ru", "invariant");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_date, CultureInfo.CreateSpecificCulture("ru-RU")), 
                MakeOutputFormat(_date, CultureInfo.InvariantCulture));

            Console.WriteLine("\n\nФорматы отображения чисел:");
            Console.WriteLine("{0, -18}{1}", "en", "ru");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_number, CultureInfo.CreateSpecificCulture("ru-RU")), 
                MakeOutputFormat(_number, CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("{0, -18}{1}", "en", "invariant");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_number, CultureInfo.CreateSpecificCulture("en-US")), 
                MakeOutputFormat(_number, CultureInfo.InvariantCulture));
            Console.WriteLine("{0, -18}{1}", "ru", "invariant");
            Console.WriteLine("{0, -18}{1}", MakeOutputFormat(_number, CultureInfo.CreateSpecificCulture("ru-RU")), 
                MakeOutputFormat(_number, CultureInfo.InvariantCulture));
            Console.WriteLine("Нажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Выставление формата чисел
        /// </summary>
        /// <param name="parNumber"> Число</param>
        /// <param name="parCulture"> Культура числа</param>
        /// <returns> Отформатированная строка</returns>
        static string MakeOutputFormat(double parNumber, CultureInfo parCulture)
        {
            return parNumber.ToString("N", parCulture);
        }

        /// <summary>
        /// Выставление формата даты
        /// </summary>
        /// <param name="parDate"> Дата</param>
        /// <param name="parCulture"> Культура даты</param>
        /// <returns> Отформатированная строка</returns>
        static string MakeOutputFormat(DateTime parDate, CultureInfo parCulture)
        {
            return parDate.ToString("d", parCulture);
        }


    }
}
