using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите количество строк массива m = ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество столбцов массива n = ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[,] _array = CreatArray(m, n);
                    Console.WriteLine("Полученный массив со случайными значениями: ");
                    ArrayOutput(_array);
                    Console.WriteLine("Сумма элементов стоящих на четных позициях: {0}", SumOfEvenPosition(_array));
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
        /// <param name="parM"> Количество строк</param>
        /// <param name="parN"> Количество столбцов</param>
        /// <returns> Полученый массив</returns>
        static int[,] CreatArray(int parM, int parN)
        {
            int[,] array = new int[parM, parN];
            Random rand = new Random();
            for (int i = 0; i < parM; i++)
            {
                for (int j = 0; j < parN; j++)
                {
                    array[i, j] = rand.Next(100);
                }
            }
            return array;
        }

        /// <summary>
        /// Нахождение суммы элементов находящихся на четной позиции
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        /// <returns> Сумма элементов находящихся на четных позициях</returns>
        static int SumOfEvenPosition(int[,] parArray)
        {
            int sum = 0;
            for (int i = 0; i < parArray.GetLength(0); i++)
            {
                for (int j = 0; j < parArray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += parArray[i, j];
                    }
                }
            }
            return sum;
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="parArray"> Входной массив</param>
        static void ArrayOutput(int[,] parArray)
        {
            for (int i = 0; i < parArray.GetLength(0); i++)
            {
                for (int j = 0; j < parArray.GetLength(1); j++)
                {
                    Console.Write(parArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
