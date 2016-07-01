using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите размер массива: ");
                    int[] _array = Task1.Program.CreateArray(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Полученный массив со случайными значениями:");
                    Task1.Program.ArrayOutput(_array);
                    Console.WriteLine("Сумма неотрицательных элементов: {0}", NonNegativSum(_array));
                    Console.ReadKey();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод!!!");
                }
            }
        }

        /// <summary>
        /// Нахождение суммы неотрицательных элементов массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        /// <returns> Сумма неотрицательных элементов</returns>
        static int NonNegativSum(int[] parArray)
        {
            int sum = 0;
            /*for (int i = 0; i < parArray.Length; i++)
            {
                if (parArray[i] > 0)
                {
                    sum += parArray[i];
                }
            }*/
            foreach (var item in parArray)
            {
                if (item > 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
