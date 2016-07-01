using System;

namespace Task2
{
    /// <summary>
    /// Class User
    /// </summary>
    class User
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private DateTime _birthday;

        public User(string Name, string Surname, string Patronymic, DateTime Birthday)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception("Вы не ввели имя!!!");
            }
            foreach (var symbol in Name)
            {
                if (char.IsNumber(symbol))
                {
                    throw new Exception("Это не имя!!!");
                }
            }
            _name = Name;
            if (string.IsNullOrWhiteSpace(Surname))
            {
                throw new Exception("Вы не ввели фамилию!!!");
            }
            foreach (var symbol in Surname)
            {
                if (char.IsNumber(symbol))
                {
                    throw new Exception("Это не фамилию!!!");
                }
            }
            _surname = Surname;
            if (string.IsNullOrWhiteSpace(Patronymic))
            {
                throw new Exception("Вы не ввели отчество!!!");
            }
            foreach (var symbol in Patronymic)
            {
                if (char.IsNumber(symbol))
                {
                    throw new Exception("Это не отчество!!!");
                }
            }
            _patronymic = Patronymic;
            if (Birthday <= DateTime.Today)
            {
                _birthday = Birthday;
            }
            else
            {
                throw new Exception("Дата больше сегодняшней!!!");
            }
        }

        /// <summary>
        /// Name of user
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
                    throw new Exception("Вы не ввели имя!!!");
                }
                foreach (var symbol in value)
                {
                    if (char.IsNumber(symbol))
                    {
                        throw new Exception("Это не имя!!!");
                    }
                }
                _name = value;
            }
        }

        /// <summary>
        /// Surname of user
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Вы не ввели фамилию!!!");
                }
                foreach (var symbol in value)
                {
                    if (char.IsNumber(symbol))
                    {
                        throw new Exception("Это не фамилию!!!");
                    }
                }
                _surname = value;
            }
        }

        /// <summary>
        /// Patronymic of user
        /// </summary>
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Вы не ввели отчество!!!");
                }
                foreach (var symbol in value)
                {
                    if (char.IsNumber(symbol))
                    {
                        throw new Exception("Это не отчество!!!");
                    }
                }
                _patronymic = value;
            }
        }

        /// <summary>
        /// Birthday of user
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value <= DateTime.Today)
                {
                    _birthday = value;
                }
                else
                {
                    throw new Exception("Дата больше сегодняшней!!!");
                }
            }
        }

        /// <summary>
        /// Age of user
        /// </summary>
        public ushort Age
        {
            get
            {
                return Convert.ToUInt16((DateTime.Today - _birthday).TotalDays / 365);
            }
        }
    }
}
