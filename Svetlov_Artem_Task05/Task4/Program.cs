using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString _mystring = new MyString("привет при");
            MyString _mystring2 = new MyString(new char[] { 'п', 'р', 'и' });
            Console.WriteLine("Строка 1: {0}", _mystring);
            Console.WriteLine("Строка 2: {0}", _mystring2);
            Console.WriteLine("Результат сравнения строк:");
            if (_mystring == _mystring2)
            {
                Console.WriteLine("Значения равны");
            }
            else
            {
                Console.WriteLine("Значения не равны");
            }
            Console.WriteLine("Результат добавление строки к строке: {0}", _mystring + _mystring2);
            Console.WriteLine("Результат вычитание подстроки из строки: {0}", (_mystring + _mystring2) - _mystring2);

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
