using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введит размер первого измерения m = ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите размер второго измерения n = ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите размер третьего измерения l = ");
                    int l = Convert.ToInt32(Console.ReadLine());
                    int[,,] _array = CreateArray(m, n, l);
                    Console.WriteLine("Трехмерный массив со случайными значениями:");
                    ArrayOutput(_array);
                    ResetPositive(_array);
                    Console.WriteLine("Трехмерный массив с обнуленными положительными значениями:");
                    ArrayOutput(_array);
                    Console.ReadKey();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод значений!!!");
                }
            }
        }

        /// <summary>
        /// Создание массива 
        /// </summary>
        /// <param name="m"> количество элементов в первом измерение</param>
        /// <param name="n"> количество элементов во втором измерение</param>
        /// <param name="l"> количество элементов в третьем измерение</param>
        /// <returns> Созданный массив</returns>
        static int[,,] CreateArray(int m, int n, int l)
        {
            int[,,] array = new int[m, n, l];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < l; k++)
                    {
                        array[i, j, k] = rand.Next(100) - 50;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Обнуление положительных значений
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        static void ResetPositive(int[,,] parArray)
        {
            for (int i = 0; i < parArray.GetLength(0); i++)
            {
                for (int j = 0; j < parArray.GetLength(1); j++)
                {
                    for (int l = 0; l < parArray.GetLength(2); l++)
                    {
                        /*if (parArray[i, j, l] > 0)
                        {
                            parArray[i, j, l] = 0;
                        }*/
                        parArray[i, j, l] = parArray[i, j, l] > 0 ? 0 : parArray[i, j, l];
                    }
                }
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        static void ArrayOutput(int[,,] parArray)
        {
            for (int i = 0; i < parArray.GetLength(0); i++)
            {
                for (int j = 0; j < parArray.GetLength(1); j++)
                {
                    for (int l = 0; l < parArray.GetLength(2); l++)
                    {
                        Console.WriteLine("array[{0}, {1}, {2}] = {3}", i, j, l, parArray[i, j, l]);
                    }
                }
            }
        }
    }
}
