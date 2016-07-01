using System;
using Entities;
using System.Collections.Generic;

namespace Department.DAL
{
    public class RewardsDAO : IRewardDAO
    {
        private List<Reward> _rewards = new List<Reward>();

        /// <summary>
        /// Add information about person
        /// </summary>
        /// <param name="reward"> Person</param>
        public void Add(Reward reward)
        {
            if (reward != null)
            {
                _rewards.Add(reward);
            }
            else
            {
                throw new Exception("Вы не ввели данные о награде!!!");
            }
        }

        /// <summary>
        /// Delete information about person
        /// </summary>
        /// <param name="reward"> Reward</param>
        public void Delete(Reward reward)
        {
            if (reward != null)
            {
                _rewards.Remove(reward);
            }
            else
            {
                throw new Exception("Вы не выбрали награду для удаления!!!");
            }
        }

        /// <summary>
        /// Edit information about reward
        /// </summary>
        /// <param name="reward"> Reward</param>
        public void Edit(Reward reward)
        {
            if (reward != null)
            {
                int index = _rewards.IndexOf(reward);
                _rewards.Remove(reward);
                _rewards.Insert(index, reward);
            }
            else
            {
                throw new Exception("Вы на выбрали награду для редактирования!!!");
            }
        }

        /// <summary>
        /// Get list of rewards
        /// </summary>
        /// <returns> List of rewards</returns>
        public IEnumerable<Reward> GetList()
        {
            return _rewards;
        }
    }
}
