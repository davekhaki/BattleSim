using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Weapon
{
    public class Weapon
    {
        protected int Damage;
        protected double MissChance = 0.1;
        protected double CritChance = 0.1;

        public Weapon(int dmg, double miss, double crit)
        {
            Damage = dmg;
            MissChance = miss;
            CritChance = crit;
        }

        public int GetDamage()
        {
            return Damage;
        }
    }
}
