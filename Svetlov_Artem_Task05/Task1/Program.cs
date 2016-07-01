using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User _user = new User();
                Console.Write("Введите имя пользователя: ");
                _user.Name = Console.ReadLine();
                Console.Write("Введите фамилию пользователя: ");
                _user.Surname = Console.ReadLine();
                Console.Write("Введите отчество пользователя: ");
                _user.Patronymic = Console.ReadLine();
                Console.Write("Введите дату рождения пользователя: ");
                _user.Birthday = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nПолучена информация о пользователя:");
                Console.WriteLine("ФИО пользователя: {1} {0} {2}\nДата рождения пользователя: {3}\nВозраст пользователя: {4}",
                    _user.Name, _user.Surname, _user.Patronymic, _user.Birthday, _user.Age);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
