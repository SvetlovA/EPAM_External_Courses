using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите начало прогрессии: ");
                double _start = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                Console.Write("Введите шаг прогресси: ");
                double _step = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                Console.Write("Введите количество элементов прогресии: ");
                uint _n = Convert.ToUInt32(Console.ReadLine());
                ISeries _arithm = new ArithmeticalProgression(_start, _step);
                IIndexable _list = new List(PrintSeries(_arithm, _n));
                Console.Write("Арифметическая прогрессия: ");
                PrintList(_list);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели некорректное значение!!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Вы ввели отрицательное количество элементов!!!");
            }

            Console.WriteLine("\nНажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        static double[] PrintSeries(ISeries series, uint n)
        {
            double[] res = new double[n];
            series.Reset();

            for (int i = 0; i < n; i++)
            {
                res[i] = series.GetCurrent();
                series.MoveNext();
            }

            return res;
        }

        static void PrintList(IIndexable series)
        {
            for (int i = 0; i < series.Length; i++)
            {
                Console.Write(series[i] + " ");
            }
        }
    }
}
