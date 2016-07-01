using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
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
        [Display(Name = "ID")]
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
        [Required, StringLength(50)]
        [Display(Name = "Имя")]
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
        [Required, StringLength(50)]
        [Display(Name = "Фамилия")]
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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
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
        [Display(Name = "Возраст")]
        public int Age
        {
            get
            {
                return DateTime.Now.Month < _birthday.Month ? DateTime.Now.Year - _birthday.Year - 1 : DateTime.Now.Year - _birthday.Year;
            }
        }

        /// <summary>
        /// Person's rewards
        /// </summary>
        [Display(Name = "Список наград")]
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
