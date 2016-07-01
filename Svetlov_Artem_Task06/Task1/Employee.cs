using System;

namespace Task1
{
    /// <summary>
    /// Class Employee
    /// </summary>
    class Employee : User
    {
        private DateTime _employmentDay;
        private string _position;

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
    }
}
