using System;

namespace Task1
{
    public class Person
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private DateTime _birthday;
        private RewardList _rewards = new RewardList();

        /// <summary>
        /// ID of person
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// First Name of person
        /// </summary>
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        /// <summary>
        /// Last name of person
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        /// Birthday
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }

        /// <summary>
        /// Number of age
        /// </summary>
        public int Age
        {
            get
            {
                return DateTime.Now.Month < _birthday.Month ? DateTime.Now.Year - _birthday.Year - 1 : DateTime.Now.Year - _birthday.Year;
            }
        }

        /// <summary>
        /// Peron's rewards
        /// </summary>
        public RewardList Rewards
        {
            get
            {
                return _rewards;
            }

            set
            {
                _rewards = value;
            }
        }
    }
}
