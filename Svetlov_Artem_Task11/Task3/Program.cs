using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("x = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            TwoDPointWithHash newPoint1 = new TwoDPointWithHash(x, y);
            TwoDPointWithHash newPoint2 = new TwoDPointWithHash(x2, y2);

            Console.WriteLine("Хэшкод первой точки {0}", newPoint1.GetHashCode());
            Console.WriteLine("Хэшкод второй точки {0}", newPoint2.GetHashCode());

            var twoDPointWithHashList = new List<TwoDPointWithHash> { newPoint1, newPoint2 };
            var distinctTwoDPointWithHashList = twoDPointWithHashList.Distinct();
            foreach (var point in distinctTwoDPointWithHashList)
            {
                Console.WriteLine("Координаты точки: {0}", point);
            }

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }
    }
}
