using System;
using System.Collections.Generic;
using System.Linq;
using Department.DAL;
using Entities;

namespace Department.BLL
{
    public class PersonsBL : IDisposable
    {
        private readonly IPersonDAO _personsDAO;

        public PersonsBL(bool sql)
        {
            if (sql)
            {
                _personsDAO = new PersonsSqlDAO();
            }
            else
            {
                _personsDAO = new PersonsDAO();
            }
        } 

        /// <summary>
        /// Create ID for person
        /// </summary>
        /// <returns></returns>
        private int CreateID()
        {
            int ID = 0;
            IEnumerable<Person> persons = _personsDAO.GetList();
            if (persons.Count() > 0)
            {
                ID = 1;
                foreach (var person in persons)
                {
                    if (ID == persons.Single(x => x.Id == person.Id).Id)
                    {
                        ID++;
                    }
                }
            }
            else
            {
                ID = 1;
            }
            return ID;
        }

        /// <summary>
        /// Add information about person
        /// </summary>
        /// <param name="firstName"> Name</param>
        /// <param name="lastName"> Surname</param>
        /// <param name="birthday"> Birthday</param>
        /// <param name="rewards"> Persons rewards</param>
        public void Add(string firstName, string lastName, DateTime birthday, RewardList rewards)
        {
            Person person = new Person
            {
                Id = CreateID(),
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday,
                Rewards = rewards
            };

            Add(person);
        }

        /// <summary>
        /// Add information about person
        /// </summary>
        /// <param name="person"> Person</param>
        public void Add(Person person)
        {
            if (person != null)
            {
                person.Id = CreateID();
                _personsDAO.Add(person);
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
                _personsDAO.Delete(person);
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
                _personsDAO.Edit(person);
            }
            else
            {
                throw new Exception("Вы не выбрали пользователя для редактирования!!!");
            }
        }

        /// <summary>
        /// Sort by ID
        /// </summary>
        /// <returns> Sorted list of persons</returns>
        public IEnumerable<Person> SortByID()
        {
            return _personsDAO.GetList().OrderBy((x) => x.Id);
        }

        /// <summary>
        /// Sort by Name
        /// </summary>
        /// <returns> Sorted list of persons</returns>
        public IEnumerable<Person> SortByFirstName()
        {
            return _personsDAO.GetList().OrderBy((x) => x.FirstName);
        }

        /// <summary>
        /// Sort by Surname
        /// </summary>
        /// <returns> Sorted list of persons</returns>
        public IEnumerable<Person> SortByLastName()
        {
            return _personsDAO.GetList().OrderBy((x) => x.LastName);
        }

        /// <summary>
        /// Sort by Birthday
        /// </summary>
        /// <returns> Sorted list of persons</returns>
        public IEnumerable<Person> SortByBirthday()
        {
            return _personsDAO.GetList().OrderBy((x) => x.Birthday);
        }

        /// <summary>
        /// Sort by Age
        /// </summary>
        /// <returns> Sorted list of persons</returns>
        public IEnumerable<Person> SortByAge()
        {
            return _personsDAO.GetList().OrderBy((x) => x.Age);
        }

        /// <summary>
        /// Sort by rewards count
        /// </summary>
        /// <returns> Sorted list persons</returns>
        public IEnumerable<Person> SortByRewardsCount()
        {
            return _personsDAO.GetList().OrderByDescending((x) => x.Rewards.RewardsList.Count);
        }

        /// <summary>
        /// Get list of persons
        /// </summary>
        /// <returns> List of persons</returns>
        public IEnumerable<Person> GetList()
        {
            return _personsDAO.GetList();
        }

        public void Dispose()
        {
            _personsDAO.Dispose();
        }
    }
}
