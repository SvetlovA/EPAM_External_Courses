using System;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _array = new string[] { "aaa", "bb", "g", "cccc", "pppppp", "ee" };
            TestThread.End += new EventHandler(Output);
			// отличный делегат для передачи параметров
            Thread _thread = new Thread(() => TestThread.OnEnd(_array));
            Console.WriteLine("Сортировка в первом потоке:");
            _thread.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Сортировка во втором потоке:");
            TestThread.Output(_array);
            Console.ReadKey();
        }

        /// <summary>
        /// Output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Output(object sender, EventArgs e)
        {
            var array = sender as string[];

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Закончено!!!");
        }
    }
}
