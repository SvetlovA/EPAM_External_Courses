using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class MedicineBonus : Bonus, IBonus
    {
        private float _healthAdd;

        /// <summary>
        /// Constructor of claas MedicinBonus
        /// </summary>
        /// <param name="healthadd">Health</param>
        public MedicineBonus(float healthadd)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Make medicin bonus
        /// </summary>
        /// <param name="player"> Person</param>
        public override void MakeBonus(Player player)
        {
            throw new NotImplementedException();
        }
    }
}