using System;

namespace Task3
{
    class TestThread
    {
        /// <summary>
        /// Sorting
        /// </summary>
        /// <param name="InputArray"> Input array</param>
        /// <returns></returns>
        public static string[] Sort(string[] InputArray)
        {
            Action<string[], int, int> SwapElsments = Task1.Program.Swap;
            Func<int, int, bool> CompareElemnts = Task1.Program.Comparison;
            int i = 0;
            while (i < InputArray.Length - 1)
            {
                if (CompareElemnts(InputArray[i + 1].Length, InputArray[i].Length))
                {
                    SwapElsments(InputArray, i, i + 1);
                    //Swap(InputArray, i, i + 1);
                    i = 0;
                }
                else if (/*Comparison(InputArray[i + 1].Length, InputArray[i].Length)*/ InputArray[i + 1].Length == InputArray[i].Length)
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

        public static event EventHandler End;

        /// <summary>
        /// End
        /// </summary>
        /// <param name="InputArray"> Input array</param>
        public static void OnEnd(string[] InputArray)
        {
            if (End != null)
            {
                End(Sort(InputArray), EventArgs.Empty);
            }
        }

        /// <summary>
        /// Output
        /// </summary>
        /// <param name="Array"> Input array</param>
        public static void Output(string[] Array)
        {
            string[] resultArray = Sort(Array);
            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
