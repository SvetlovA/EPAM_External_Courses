using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] _test = new string[] {"cc", "aaa", "aa", "a", "bb", "whkjooo", "gqeyigu" };
            Console.WriteLine("Исходный массив:");
            Output(_test);
            Sort(_test, Swap, compare1, compare2);
            Console.WriteLine("Отсортированный массив:");
            Output(_test);

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Delegate fo comparing
        /// </summary>
        /// <param name="length1"> Length of first string</param>
        /// <param name="length2"> Length of second string</param>
        /// <returns></returns>
        public delegate bool Compare2(int length1, int length2);

        static Compare2 compare2 = delegate (int length1, int length2)
        {
            if (length1 == length2)
            {
                return true;
            }
            else
            {
                return false;
            }
        };


        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="InputArray"> Input array</param>
        /// <param name="word1"> Word</param>
        /// <param name="word2"> Word</param>
        public static void Swap(string[] InputArray, int word1, int word2)
        {
            string temp = InputArray[word1];
            InputArray[word1] = InputArray[word2];
            InputArray[word2] = temp;
        }

        /// <summary>
        /// Comparison of lengths
        /// </summary>
        /// <param name="length1"> Length</param>
        /// <param name="length2"> Length</param>
        /// <returns> Compare or not compare</returns>
        public static bool Comparison(int length1, int length2)
        {
            if (length1 < length2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Delegate fo comparision
        /// </summary>
        static Func<int, int, bool> compare1 = (a, b) =>
        {
            if (a < b)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        /// <summary>
        /// Sort
        /// </summary>
        /// <param name="InputArray"> Input array</param>
        /// <param name="SwapElements"> Deleget for swap elements</param>
        /// <param name="Compare1"> Delegate for compare elements</param>
        /// <param name="Compare2"> Delegate for compare elements</param>
        /// <returns></returns>
//#error делегат нужжно передавать как параметр в методб чтобы сортировка могла работать с разными условиями сравнения
//#error иначе это не отличается от простого вызова метода
        static string[] Sort(string[] InputArray, Action<string[], int, int> SwapElements, Func<int, int, bool> Compare1, Compare2 Compare2)
        {
           // Action<string[], int, int> SwapElsments = Swap;
            //Func<int, int, bool> CompareElemnts = Comparison;
            int i = 0;
            while (i < InputArray.Length - 1)
            {
                if (/*CompareElemnts(InputArray[i + 1].Length, InputArray[i].Length)*/ Compare1(InputArray[i + 1].Length, InputArray[i].Length))
                {
                    SwapElements(InputArray, i, i + 1);
                    //Swap(InputArray, i, i + 1);
                    i = 0;
                }
                else if (Compare2(InputArray[i + 1].Length, InputArray[i].Length))
                {
                    Array.Sort(InputArray, i, 2);
                    i++;
                }
                else
                {
                    i++;
                }
            }
            return InputArray;
        }

        /// <summary>
        /// Output
        /// </summary>
        /// <param name="Array"> Input array</param>
        static void Output(string[] Array)
        {
            foreach (var word in Array)
            {
                Console.WriteLine(word);
            }
        }
    }
}
