using System;

namespace Task2
{
    class Person
    {
        private string _name;

        /// <summary>
        /// Name of person
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Имя не может быть пустым");
                }
                foreach (var symbol in value)
                {
                    if (char.IsNumber(symbol))
                    {
                        throw new Exception("Имя не может содержать цифры");
                    }
                }
                _name = value;
            }
        }

        /// <summary>
        /// Greeting person
        /// </summary>
        /// <param name="person"> Person</param>
        /// <param name="time"> Time</param>
        public void Greeting(Person person, DateTime time)
        {
            if (time.Hour < 12 && time.Hour >= 8)
            {
                Console.WriteLine("Доброе утро {0}!!! - сказал {1}", person.Name, Name);
            }
            else if (time.Hour >= 12 && time.Hour <= 17)
            {
                Console.WriteLine("Добрый день {0}!!! - сказал {1}", person.Name, Name);
            }
            else
            {
                Console.WriteLine("Добрый вечер {0}!!! - сказал {1}", person.Name, Name);
            }
        }

        /// <summary>
        /// Parting with person
        /// </summary>
        /// <param name="person"> Person</param>
        public void Parting(Person person)
        {
            Console.WriteLine("Досвидания {0}!!! - сказал {1}", person.Name, Name);
        }

        public event EventHandler Came;
        public event EventHandler Leave;

        /// <summary>
        /// Came
        /// </summary>
        public void OnCame()
        {
            if (Came != null)
            {
                Came(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Leave
        /// </summary>
        public void OnLeave()
        {
            if (Leave != null)
            {
                Leave(this, EventArgs.Empty);
            }
        }
    }
}
