using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите путь директории за которой следить: ");
                string dir = Console.ReadLine();
                using (Spy _spy = new Spy(dir))
                {
                    if (args[0] == "spy")
                    {
                        _spy.Run();
                        Console.WriteLine("Режим отслеживания включен, отслеживаемая папка {0}, для выхода нажмите любую кнопку.", dir);
                        Console.ReadKey();
                    }
                    if (args[0] == "recover")
                    {
                        Console.WriteLine("Включен режим отката.");
                        Console.Write("Введите дату и время до которой нужно откатить файлы(d/m/yyyy h:mm:ss): ");
                        _spy.Recover(Convert.ToDateTime(Console.ReadLine()));
                        Console.WriteLine("Для выхода нажмите любую клавишу...");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
