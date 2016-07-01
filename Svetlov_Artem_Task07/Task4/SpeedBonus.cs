using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class SpeedBonus : Bonus, IBonus
    {
        private float _speedAdd;

        /// <summary>
        /// Constructor of class SpeedBonus
        /// </summary>
        /// <param name="speedadd">Speed</param>
        public SpeedBonus(float speedadd)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Make speed bonus
        /// </summary>
        /// <param name="player"> Person</param>
        public override void MakeBonus(Player player)
        {
            throw new NotImplementedException();
        }
    }
}