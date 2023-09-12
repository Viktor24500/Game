using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Equipment.Weapons
{
    public class Maul : IIncreaseAttack
    {
        //A maul may refer to any number of large hammers
        public void IncreaseAttack()
        {
            int increaseAttack = 10;
        }
    }
}
