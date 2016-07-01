using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите сторону a: ");
                double _a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону b: ");
                double _b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону c: ");
                double _c = Convert.ToDouble(Console.ReadLine());

                Triangle _triangle = new Triangle(_a, _b, _c);

                Console.WriteLine("Сторны треугольгика a, b, c: {0}, {1}, {2}", _triangle.A, _triangle.B, _triangle.C);
                Console.WriteLine("Площадь треугольника: {0}", _triangle.GetArea());
                Console.WriteLine("Периметр треугольника: {0}", _triangle.GetPerimeter());
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
