using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee _employee = new Employee();
                Console.Write("Введите имя пользователя: ");
                _employee.Name = Console.ReadLine();
                Console.Write("Введите фамилию пользователя: ");
                _employee.Surname = Console.ReadLine();
                Console.Write("Введите отчество пользователя: ");
                _employee.Patronymic = Console.ReadLine();
                Console.Write("Введите дату рождения пользователя (dd:mm:yyyy): ");
                _employee.Birthday = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите дату приема на работу (dd:mm:yyyy): ");
                _employee.EmploymentDay = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите должность пользователя: ");
                _employee.Position = Console.ReadLine();

                Console.WriteLine("\nПолучена информация о пользователе:");
                Console.WriteLine("ФИО пользователя: {1} {0} {2}\nДата рождения пользователя: {3}\nВозраст пользователя: {4}\nДата приема на работу: {5}\nДолжность: {6}\nСтаж: {7}",
                    _employee.Name, _employee.Surname, _employee.Patronymic, _employee.Birthday, _employee.Age, _employee.EmploymentDay, _employee.Position, _employee.Experience);
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
