using System;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введит число для получения факториала и степени: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень, в которую нужно возвести число: ");
            int power = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("{0}! = {1}", x, MathFunctions.Fact(x));
            Console.WriteLine("{0}^{1} = {2}", x, power, MathFunctions.Pow(x, power));

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }
    }
}
