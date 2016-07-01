using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите сторону a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите сторону b: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a > 0 && b > 0)
                    {
                        Console.Write("Площадь прямоугольника: {0}\n", a * b);
                    }
                    else
                    {
                        Console.WriteLine("Введены отрицательные или нулевые значения");
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный ввод значения");
                }
            }
            Console.ReadKey();
        }
    }
}
