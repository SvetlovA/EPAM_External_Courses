using System;
using System.Collections.Generic;
using Entities;

namespace Department.DAL
{
    public class PersonsDAO : IPersonDAO
    {
        private List<Person> _persons = new List<Person>();

        /// <summary>
        /// Add information about person
        /// </summary>
        /// <param name="person"> Person</param>
        public void Add(Person person)
        {
            if (person != null)
            {
                _persons.Add(person);
            }
            else
            {
                throw new Exception("Вы не ввели данные о пользователе!!!");
            }
        }

        /// <summary>
        /// Delete information about person
        /// </summary>
        /// <param name="person"> Person</param>
        public void Delete(Person person)
        {
            if (person != null)
            {
                _persons.Remove(person);
            }
            else
            {
                throw new Exception("Вы не выбрали пользователя для удаления!!!");
            }
        }

        /// <summary>
        /// Edit information about person
        /// </summary>
        /// <param name="person"> Person</param>
        public void Edit(Person person)
        {
            if (person != null)
            {
                int index = _persons.IndexOf(person);
                _persons.Remove(person);
                _persons.Insert(index, person);
            }
            else
            {
                throw new Exception("Вы не выбрали пользователя для изменения!!!");
            }
        }

        /// <summary>
        /// Get list of persons
        /// </summary>
        /// <returns> List of persons</returns>
        public IEnumerable<Person> GetList()
        {
            return _persons;
        }
    }
}
