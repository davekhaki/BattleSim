using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim.Character
{
    public class Character
    {
        protected virtual int health { get; set; }
        protected bool alive = true;

        public Character(int hp, bool alive)
        {
            health = hp;
            this.alive = alive;
        }


        public virtual void DealDamage(Character enemy)
        {

        }

        public virtual void TakeDamage(int dmg)
        {

        }

        public virtual void Die()
        {
            alive = false;
        }

        public override string ToString()
        {
            return $"HP: {health}, ALIVE: {alive}";
        }
    }
}
