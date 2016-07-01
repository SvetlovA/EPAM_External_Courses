using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DynamicArray<int> _test = new DynamicArray<int>(new int[] {1, 2, 3});
                Console.WriteLine("Созданный массив:");
                Print(_test);
                Console.WriteLine("Длинна заполненной части массива: {0}. Реальная емкость массива: {1}", _test.Length, _test.Capacity);
                Console.WriteLine("\nРезультат добавления элемента в конец:");
                _test.Add(23);
                Print(_test);
                Console.WriteLine("Длинна заполненной части массива: {0}. Реальная емкость массива: {1}", _test.Length, _test.Capacity);
                Console.WriteLine("\nРезультат добавления массива в конец:");
                _test.AddRange(new int[] { 1, 2, 3, 4 });
                Print(_test);
                Console.WriteLine("Длинна заполненной части массива: {0}. Реальная емкость массива: {1}", _test.Length, _test.Capacity);
                Console.Write("Введите элемент, который следует удалить: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nРезультат удаления элемента {0} из массива:", n);
                Console.WriteLine("Выполнено ли удаление: {0}", _test.Remove(n));
                Print(_test);
                Console.WriteLine("Длинна заполненной части массива: {0}. Реальная емкость массива: {1}", _test.Length, _test.Capacity);
                Console.Write("Введите элемент, который следует вставить: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите на какую позицию следует вставить элемент {0}: ", n);
                int _position = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nРезультат вставки элемента {0} в массив на позицию {1}:", n, _position);
                Console.WriteLine("Выполнена ли вставка: {0}", _test.Insert(n, _position));
                Print(_test);
                Console.WriteLine("Длинна заполненной части массива: {0}. Реальная емкость массива: {1}", _test.Length, _test.Capacity);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        static void Print<T>(DynamicArray<T> array) where T : new()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Array[{0}] = {1}", i, array[i]);
            }
        }
    }
}
