using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public class Character
    {
        protected virtual int health { get; set; }
        protected virtual Weapon equippedWeapon { get; set; }
        protected bool alive = true;


        public virtual void DealDamage()
        {

        }

        public virtual void TakeDamage(int dmg)
        {

        }

        public virtual void Die()
        {
            alive = false;
        }
    }
}
