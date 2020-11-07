using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Sword : Weapon
    {
        public Sword(int dmg, double miss, double crit) : base(10, miss, crit)
        {

        }
    }
}
