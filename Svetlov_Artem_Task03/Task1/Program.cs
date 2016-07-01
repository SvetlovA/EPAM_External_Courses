using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите размер массива: ");
                    int[] _array = CreateArray(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Полученный массив со случайными значениями:");
                    ArrayOutput(_array);
                    Console.WriteLine("Максимльное значение массива: {0}", Max(_array));
                    Console.WriteLine("Минимальное значение массива: {0}", Min(_array));
                    BubbleSort(_array);
                    Console.WriteLine("Отсортированный массив:");
                    ArrayOutput(_array);
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
        /// Создание массива
        /// </summary>
        /// <param name="parN"> Количество элементов массива</param>
        /// <returns> Сгенерированный массив</returns>
        public static int[] CreateArray(int parN)
        {
            int[] array = new int[parN];
            Random rand = new Random();
            for (int i = 0; i < parN; i++)
            {
                array[i] = rand.Next(100);
            }
            return array;   
        }

        /// <summary>
        /// Находление максимального значения массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        /// <returns> Максимальное значение</returns>
        static int Max(int[] parArray)
        {
            int maxElement = parArray[0];
            for (int i = 0; i < parArray.Length; i++)
            {
                if (maxElement < parArray[i])
                {
                    maxElement = parArray[i];
                }
            }
            return maxElement;
        }

        /// <summary>
        /// Нахождение минимального значения массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        /// <returns> Минимальное значение</returns>
        static int Min(int[] parArray)
        {
            int minElement = parArray[0];
            for (int i = 0; i < parArray.Length; i++)
            {
                if (minElement > parArray[i])
                {
                    minElement = parArray[i];
                }
            }
            return minElement;
        }

        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        static void BubbleSort(int[] parArray)
        {
            for (int i = 0; i < parArray.Length - 1; i++)
            {
                for (int j = i + 1; j < parArray.Length; j++)
                {
                    if (parArray[j] < parArray[i])
                    {
                        var temp = parArray[i];
                        parArray[i] = parArray[j];
                        parArray[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        public static void ArrayOutput(int[] parArray)
        {
            for (int i = 0; i < parArray.Length; i++)
            {
                Console.WriteLine("array[{0}] = {1}", i, parArray[i]);
            }
        }
    }
}
