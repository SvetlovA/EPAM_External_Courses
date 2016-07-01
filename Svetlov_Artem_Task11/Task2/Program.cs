using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введит имя первого рабочего: ");
                string _name = Console.ReadLine();
                Console.Write("Введите Фамилию первого пользователя: ");
                string _surname = Console.ReadLine();
                Console.Write("Введите отчество первого пользователя: ");
                string _patronymic = Console.ReadLine();
                Console.Write("Введите дату рождения первого пользователя: ");
                DateTime _birthday = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите дату приема на работу рождения первого пользователя: ");
                DateTime _employmentDay = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите должность первого пользователя: ");
                string _position = Console.ReadLine();

                Console.Write("Введит имя второго рабочего: ");
                string _name2 = Console.ReadLine();
                Console.Write("Введите Фамилию второго пользователя: ");
                string _surname2 = Console.ReadLine();
                Console.Write("Введите отчество второго пользователя: ");
                string _patronymic2 = Console.ReadLine();
                Console.Write("Введите дату рождения второго пользователя: ");
                DateTime _birthday2 = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите дату приема на работу рождения второго пользователя: ");
                DateTime _employmentDay2 = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите должность второго пользователя: ");
                string _position2 = Console.ReadLine();

                Employee Mirich = new Employee(_name, _surname, _patronymic, _birthday, _employmentDay, _position);
                Employee Fedor = new Employee(_name2, _surname2, _patronymic2, _birthday2, _employmentDay2, _position2);
                Console.WriteLine(Mirich.Equals(Fedor) ? "Одинаковые рабочие" : "Разные рабочие");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }
    }
}
