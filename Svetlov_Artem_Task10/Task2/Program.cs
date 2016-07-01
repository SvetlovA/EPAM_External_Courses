using System;

namespace Task2
{
    class Program
    {
        static MessageCame greetByUs;
        static MessageLeave partingByUs;
        delegate void MessageCame(Person name, DateTime time);
        delegate void MessageLeave(Person name);

        static void Main(string[] args)
        {
            Person Mitrich = new Person { Name = "Кирилл" };
            Person Fedor = new Person { Name = "Диман" };

            Mitrich.Came += new EventHandler(PersonCame);
            Fedor.Came += new EventHandler(PersonCame);

            Mitrich.Leave += new EventHandler(PersonLeave);
            Fedor.Leave += new EventHandler(PersonLeave);

            Fedor.OnCame();
            Mitrich.OnCame();

            Fedor.OnLeave();
            Mitrich.OnLeave();

            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Cameof person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void PersonCame(object sender, EventArgs e)
        {
            var person = sender as Person;

            if (person != null)
            {
                Console.WriteLine("{0} пришел", person.Name);
                if (greetByUs != null)
                {
                    greetByUs(person, DateTime.Now);
                }

                greetByUs += new MessageCame(person.Greeting);
                partingByUs += new MessageLeave(person.Parting);
            }
        }

        /// <summary>
        /// Leave of person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void PersonLeave(object sender, EventArgs e)
        {
            var person = sender as Person;

            if (person != null)
            {
                Console.WriteLine("{0} ушел", person.Name);
                partingByUs -= new MessageLeave(person.Parting);

                if (partingByUs != null)
                {
                    partingByUs(person);
                }
            }
        }
    }
}
