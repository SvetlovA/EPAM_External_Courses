using System;
using System.Collections.Generic;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Department.DAL
{
    public class PersonsSqlDAO : IPersonDAO
    {
        private SqlConnection _connection;

        /// <summary>
        /// Constructor
        /// </summary>
        public PersonsSqlDAO()
        {
            InitConnection();
        }

        /// <summary>
        /// Initialize connection 
        /// </summary>
        private void InitConnection()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PersonsRewards"].ConnectionString);
            _connection.Open();
            _connection.StateChange += ConnectionStateChange;
        }

        private void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
            {
                InitConnection();
            }
        }

        /// <summary>
        /// Add information about person to database
        /// </summary>
        /// <param name="person"> Information about person</param>
        public void Add(Person person)
        {
            InsertPerson(person);
            AddReward(person);
        }

        /// <summary>
        /// Delete information about person from database
        /// </summary>
        /// <param name="person"> Information about person</param>
        public void Delete(Person person)
        {
            DeletePerson(person);
        }

        /// <summary>
        /// Edit information about person in database
        /// </summary>
        /// <param name="person"> Information about person</param>
        public void Edit(Person person)
        {
            UpdatePerson(person);
        }

        /// <summary>
        /// Get information about person from database
        /// </summary>
        /// <returns> List of persons</returns>
        public IEnumerable<Person> GetList()
        {
            return PersonsRewards();
        }

        private void UpdatePerson(Person person)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Persons SET FirstName = @FirstName, LastName = @LastName, Birthday = @Birthday, Age = @Age WHERE PersonID = @PersonID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Birthday", SqlDbType.Date));
                command.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int));

                command.Parameters[0].Value = person.Id;
                command.Parameters[1].Value = person.FirstName;
                command.Parameters[2].Value = person.LastName;
                command.Parameters[3].Value = person.Birthday;
                command.Parameters[4].Value = person.Age;

                var result = command.ExecuteNonQuery();
            }
            UpdateRewards(person);
        }

        private void AddReward(Person person)
        {
            foreach (var reward in person.Rewards.RewardsList)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Awarded VALUES(@PersonID, @RewardID)", _connection))
                {
                    command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int));
                    command.Parameters.Add(new SqlParameter("@RewardID", SqlDbType.Int));

                    command.Parameters[0].Value = person.Id;
                    command.Parameters[1].Value = reward.Id;

                    var result = command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteRewards(Person person)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Awarded WHERE PersonID = @PersonID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int));

                command.Parameters[0].Value = person.Id;

                var result = command.ExecuteNonQuery();
            }
        }

        private void UpdateRewards(Person person)
        {
            DeleteRewards(person);
            AddReward(person);
        }

        private IEnumerable<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Persons", _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        persons.Add(new Person()
                        {
                            Id = (int)reader["PersonID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Birthday = Convert.ToDateTime(reader["Birthday"]),
                        });
                    }
                }
            }
            return persons;
        }

        private IEnumerable<Person> PersonsRewards()
        {
            IEnumerable<Person> persons = GetPersons();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Rewards INNER JOIN Awarded ON Awarded.RewardID = Rewards.RewardID WHERE Awarded.PersonID = @ID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                foreach (var person in persons)
                {
                    command.Parameters[0].Value = person.Id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            person.Rewards.RewardsList.Add(new Reward
                            {
                                Id = (int)reader["RewardID"],
                                Title = (string)reader["Title"],
                                Description = (string)reader["Description"]
                            });
                        }
                    }
                }
            }
            return persons;
        }

        private void InsertPerson(Person person)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Persons(PersonID, FirstName, LastName, Birthday, Age) VALUES(@PersonID, @FirstName, @LastName, @Birthday, @Age)", _connection))
            {
                // параметры добавлять только так. не строкой!
                command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Birthday", SqlDbType.Date));
                command.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int));

                // обязательно вызывать при добавлении параметров
                //command.Prepare();

                command.Parameters[0].Value = person.Id;
                command.Parameters[1].Value = person.FirstName;
                command.Parameters[2].Value = person.LastName;
                command.Parameters[3].Value = person.Birthday;
                command.Parameters[4].Value = person.Age;


                // выполняем
                var result = command.ExecuteNonQuery();
            }
        }

        private void DeletePerson(Person person)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Persons WHERE PersonID = @PersonID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int));

                command.Parameters[0].Value = person.Id;

                var result = command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Dispose connection
        /// </summary>
        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}
