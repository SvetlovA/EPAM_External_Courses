using System;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Department.DAL
{
    public class RewardsSqlDAO : IRewardDAO
    {
        private SqlConnection _connection;

        /// <summary>
        /// Constructor
        /// </summary>
        public RewardsSqlDAO()
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
        /// Add information about reward to database
        /// </summary>
        /// <param name="reward"> Information about reward</param>
        public void Add(Reward reward)
        {
            InsertReward(reward);
        }

        /// <summary>
        /// Delete information about reward from database
        /// </summary>
        /// <param name="reward"> Information about reward</param>
        public void Delete(Reward reward)
        {
            DeleteReward(reward);
        }

        /// <summary>
        /// Edit information about reward
        /// </summary>
        /// <param name="reward"> Information about reward</param>
        public void Edit(Reward reward)
        {
            EditReward(reward);
        }

        /// <summary>
        /// Get list of rewards from database
        /// </summary>
        /// <returns> List of rewards</returns>
        public IEnumerable<Reward> GetList()
        {
            List<Reward> rewards = new List<Reward>();
            using (SqlCommand command = new SqlCommand("SELECT * FROM Rewards", _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rewards.Add(new Reward
                        {
                            Id = (int)reader["RewardID"],
                            Title = (string)reader["Title"],
                            Description = (string)reader["Description"]
                        });
                    }
                }
            }
            return rewards;
        }

        private void InsertReward(Reward reward)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO Rewards VALUES(@RewardID, @Title, @Description)", _connection))
            {
                command.Parameters.Add(new SqlParameter("@RewardID", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar));

                command.Parameters[0].Value = reward.Id;
                command.Parameters[1].Value = reward.Title;
                command.Parameters[2].Value = reward.Description;

                var result = command.ExecuteNonQuery();
            }
        }

        private void DeleteReward(Reward reward)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM Rewards WHERE RewardID = @RewardID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@RewardID", SqlDbType.Int));

                command.Parameters[0].Value = reward.Id;

                var result = command.ExecuteNonQuery();
            }
        }

        private void EditReward(Reward reward)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Rewards SET Title = @Title, Description = @Description WHERE RewardID = @RewardID", _connection))
            {
                command.Parameters.Add(new SqlParameter("@RewardID", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar));

                command.Parameters[0].Value = reward.Id;
                command.Parameters[1].Value = reward.Title;
                command.Parameters[2].Value = reward.Description;

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
