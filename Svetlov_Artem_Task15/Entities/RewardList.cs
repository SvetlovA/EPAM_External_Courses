using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RewardList
    {
        private List<Reward> _rewardsList = new List<Reward>();

        /// <summary>
        /// Reward list
        /// </summary>
        public List<Reward> RewardsList
        {
            get
            {
                return _rewardsList;
            }

            set
            {
                _rewardsList = value;
            }
        }

        /// <summary>
        /// Overriding to string for list of rewards
        /// </summary>
        /// <returns> Elements of list of reward</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (_rewardsList.Count > 1)
            {
                foreach (var reward in _rewardsList)
                {
                    if (_rewardsList.IndexOf(reward) == _rewardsList.Count - 1)
                    {
                        sb.Append(reward.Title);
                    }
                    else
                    {
                        sb.Append(reward.Title + ", ");
                    }
                }
            }
            else
            {
                foreach (var reward in _rewardsList)
                {
                    sb.Append(reward.Title);
                }
            }
            return sb.ToString();
        }
    }
}
