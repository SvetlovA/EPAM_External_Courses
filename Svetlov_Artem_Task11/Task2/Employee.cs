using System;

namespace Task2
{
    /// <summary>
    /// Class Employee
    /// </summary>
    class Employee : User, IEquatable<Employee>
    {
        private DateTime _employmentDay;
        private string _position;

        public Employee(string Name, string Surname, string Patronymic, DateTime Birthday, DateTime EmploymentDay, string Position) : base(Name, Surname, Patronymic, Birthday)
        {
            if (EmploymentDay > DateTime.Today)
            {
                throw new Exception("Вы ввели дату приема больше сегодняшней даты!!!");
            }
            else if (Convert.ToUInt32((EmploymentDay - Birthday).Days / 365) < 16)
            {
                throw new Exception("Вы ввели дату, когда пользователю еще небыло 16 лет!!!");
            }
            else
            {
                _employmentDay = EmploymentDay;
            }
            if (string.IsNullOrWhiteSpace(Position))
            {
                throw new Exception("Вы не ввели должность!!!");
            }
            else
            {
                _position = Position;
            }
        }

        /// <summary>
        /// Position of user
        /// </summary>
        public string Position
        {
            get
            {
                return _position;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Вы не ввели должность!!!");
                }
                else
                {
                    _position = value;
                }
            }
        }

        /// <summary>
        /// Employment day
        /// </summary>
        public DateTime EmploymentDay
        {
            get
            {
                return _employmentDay;
            }

            set
            {
                if (value > DateTime.Today)
                {
                    throw new Exception("Вы ввели дату приема больше сегодняшней даты!!!");
                }
                else if (Convert.ToUInt16((value - Birthday).TotalDays / 365) < 16)
                {
                    throw new Exception("Вы ввели дату, когда пользователю еще небыло 16 лет!!!");
                }
                else
                {
                    _employmentDay = value;
                }
            }
        }

        /// <summary>
        /// Experience of user
        /// </summary>
        public ushort Experience
        {
            get
            {
                return Convert.ToUInt16((DateTime.Today - _employmentDay).TotalDays / 365);
            }
        }

        /// <summary>
        /// Realisation of method Equals
        /// </summary>
        /// <param name="other"> Input parameter</param>
        /// <returns> Equals or not</returns>
        public bool Equals(Employee other)
        {
            if (other != null)
            {
                return Name == other.Name
                    && Surname == other.Surname
                    && Patronymic == other.Patronymic
                    && Age == other.Age
                    && Position == other.Position
                    && Experience == other.Experience;
            }
            else
            {
                return false;
            }

        }
    }
}
