using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> _list = new List<int>();
            Console.Write("Введите размер списка: ");
            CompleatList(_list, Convert.ToInt32(Console.ReadLine()));
            DynamicArray<int> array = new DynamicArray<int>(_list);
            DynamicArray<int> array2 = new DynamicArray<int>();
            Console.WriteLine("Полученный массив:");
            Output(array);
            Console.WriteLine("Длинна коллекции: {0}, Емкость коллекции: {1}", array.Length, array.Capacity);
            array2.Add(23);
            Output(array2);

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Compleating List
        /// </summary>
        /// <param name="list"> Input list</param>
        /// <param name="N"> Length of list</param>
        static void CompleatList(List<int> list, int N)
        {
            for (int i = 0; i < N; i++)
            {
                list.Add(i);
            }
        }

        /// <summary>
        /// Output array
        /// </summary>
        /// <param name="array"> Input array</param>
        static void Output(DynamicArray<int> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine("Array = {0}", element);
            }
        }
    }
}
