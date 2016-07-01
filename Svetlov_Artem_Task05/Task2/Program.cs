using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату X круга: ");
                double _x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату Y круга: ");
                double _y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату радиус круга: ");
                double _radious = Convert.ToDouble(Console.ReadLine());

                Round _round = new Round(_x, _y, _radious);

                Console.WriteLine("Координаты круга X и Y: ({0}, {1})", _round.X, _round.Y);
                Console.WriteLine("Радиус круга: {0}", _round.Radius);
                Console.WriteLine("Площадь круга: {0}", _round.Area);
                Console.WriteLine("Длина окружности: {0}", _round.LengthOfCircle);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение!!!");
            }
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
