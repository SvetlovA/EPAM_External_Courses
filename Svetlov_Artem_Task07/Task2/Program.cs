using System;

namespace Task2
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
                ISeries _geom = new GeometricalProgression(_start, _step);
                Console.Write("Арифметическая прогрессия: ");
                PrintSeries(_arithm, _n);
                Console.Write("\nГеометрическая прогрессия: ");
                PrintSeries(_geom, _n);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели некорректное значение!!!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Вы ввели количество элементов меньше нуля!!!");
            }

            Console.WriteLine("\nНажмите любую кнопку для завершения...");
            Console.ReadKey();
        }

        static void PrintSeries(ISeries series, uint n)
        {
            series.Reset();

            for (int i = 0; i < n; i++)
            {
                Console.Write(series.GetCurrent() + " ");
                series.MoveNext();
            }
        }
    }
}
