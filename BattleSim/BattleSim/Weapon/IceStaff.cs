using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Weapon
{
    public class IceStaff : Weapon
    {
        private int ManaCost = 75;

        public IceStaff(int dmg, double miss, double crit, int mana) : base(10, miss, crit)
        {
            this.ManaCost = mana;
        }
    }
}
