using Department.DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Department.BLL
{
    public class RewardsBL : IDisposable
    {
        private readonly IRewardDAO _rewardsDAO;

        public RewardsBL(bool sql)
        {
            if (sql)
            {
                _rewardsDAO = new RewardsSqlDAO();
            }
            else
            {
                _rewardsDAO = new RewardsDAO();
            }
        }

        /// <summary>
        /// Create ID for reward
        /// </summary>
        /// <returns> Rewards ID</returns>
        private int CreateID()
        {
            int ID = 0;
            IEnumerable<Reward> rewards = _rewardsDAO.GetList();
            if (rewards.Count() > 0)
            {
                ID = 1;
                foreach (var reward in rewards)
                {
                    if (ID == rewards.Single(x => x.Id == reward.Id).Id)
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
        /// Add information about reward
        /// </summary>
        /// <param name="title"> Title of reward</param>
        /// <param name="description"> Description of reward</param>
        public void Add(string title, string description)
        {
            Reward reward = new Reward
            {
                Id = CreateID(),
                Title = title,
                Description = description
            };

            Add(reward);
        }

        /// <summary>
        /// Add information about reward
        /// </summary>
        /// <param name="reward"> Reward</param>
        public void Add(Reward reward)
        {
            if (reward != null)
            {
                reward.Id = CreateID();
                _rewardsDAO.Add(reward);
            }
            else
            {
                throw new Exception("Вы не ввели данные о награде!!!");
            }
        }

        /// <summary>
        /// Delete information about reward
        /// </summary>
        /// <param name="reward"> Reward</param>
        public void Delete(Reward reward, IEnumerable<Person> persons)
        {
            if (reward != null)
            {
                if (persons != null)
                {
                    DeletePersonsRewards(reward, persons);
                }
                _rewardsDAO.Delete(reward);
            }
            else
            {
                throw new Exception("Вы не выбрали награду для удаления!!!");
            }
        }

        private void DeletePersonsRewards(Reward reward, IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                foreach (var rewarditem in person.Rewards.RewardsList)
                {
                    if (rewarditem == reward)
                    {
                        person.Rewards.RewardsList.Remove(rewarditem);
                        break;
                    }
                }
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
                _rewardsDAO.Edit(reward);
            }
            else
            {
                throw new Exception("Вы не выбрали пользователя для редактирования!!!");
            }
        }

        /// <summary>
        /// Sort by ID
        /// </summary>
        /// <returns> Sorted list of rewards</returns>
        public IEnumerable<Reward> SortByID()
        {
            return _rewardsDAO.GetList().OrderBy((x) => x.Id);
        }

        /// <summary>
        /// Sort by Title
        /// </summary>
        /// <returns> Sorted list of rewards</returns>
        public IEnumerable<Reward> SortByTitle()
        {
            return _rewardsDAO.GetList().OrderBy((x) => x.Title);
        }

        /// <summary>
        /// Sort by Description
        /// </summary>
        /// <returns> Sorted list of rewards</returns>
        public IEnumerable<Reward> SortByDescription()
        {
            return _rewardsDAO.GetList().OrderBy((x) => x.Description);
        }

        /// <summary>
        /// Get list of rewards
        /// </summary>
        /// <returns> List of rewards</returns>
        public IEnumerable<Reward> GetList()
        {
            return _rewardsDAO.GetList();
        }

        public void Dispose()
        {
            _rewardsDAO.Dispose();
        }
    }
}
