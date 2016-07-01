using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("Text file for Task1");
            FileInfo _file = new FileInfo(@"Text file for Task1\disposable_task_file.txt");
            ToSquare(_file);

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

       /* /// <summary>
        /// Creating random numbers and write there to text file
        /// </summary>
        /// <param name="file"> Input file</param>
        /// <param name="count"> Count of random numbers</param>
        static void WriteRnd(FileInfo file, int count)
        {
            using (StreamWriter sw = file.CreateText())
            {
                Random rnd = new Random();
                Console.WriteLine("Полученный список рандомных чисел от 0 до 100:");
                for (int i = 0; i < count; i++)
                {
                    int number = rnd.Next(100);
                    sw.WriteLine(number);
                    Console.WriteLine("Элемент {0}: {1}", i + 1, number);
                }
            }
        }*/

        /// <summary>
        /// Make square to numbers in file and write there to text file
        /// </summary>
        /// <param name="file"> Input file</param>
        static void ToSquare(FileInfo file)
        {
            string[] text = File.ReadAllLines(file.FullName);
            Console.WriteLine("Список элементов, возведенных во вторую степень:");
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Convert.ToString(Math.Pow(Convert.ToInt32(text[i]), 2));
                Console.WriteLine("Элемент {0}: {1}", i + 1, text[i]);
            }
            File.WriteAllLines(file.FullName, text);
        }
    }
}
