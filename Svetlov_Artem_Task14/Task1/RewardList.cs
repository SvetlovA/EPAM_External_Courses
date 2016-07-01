using System.Collections.Generic;
using System.Text;

namespace Task1
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
            foreach (var reward in _rewardsList)
            {
                sb.Append(reward.Title + " ");
            }
            return sb.ToString();
        }
    }
}
