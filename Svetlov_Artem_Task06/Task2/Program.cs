using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату X кольца: ");
                double _x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координату Y кольца: ");
                double _y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите внутренний радиус кольца: ");
                double _radious = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите внешний радиус кольца: ");
                double _innerRadious = Convert.ToDouble(Console.ReadLine());

                Ring _ring = new Ring(_x, _y, _radious, _innerRadious);

                Console.WriteLine("\nПолученное кольцо:");
                Console.WriteLine("Координаты кольца X и Y: ({0}, {1})", _ring.X, _ring.Y);
                Console.WriteLine("Внутренний радиус кольца: {0}", _ring.Radius);
                Console.WriteLine("Внешний радиус кольца: {0}", _ring.ExternalRadius);
                Console.WriteLine("Площадь внутреннего круга: {0}", _ring.AreaOfCircle);
                Console.WriteLine("Площадь кольца: {0}", _ring.AreaOfRing);
                Console.WriteLine("Длина внутренней окружности: {0}", _ring.LengthOfCircle);
                Console.WriteLine("Общай длинна внешнего и внутреннего круга: {0}", _ring.LengthOfRing);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
