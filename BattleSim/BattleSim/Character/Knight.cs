using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Character
{
    public class Knight : Character
    {
        protected override int health 
        { 
            get => base.health; 
            set => base.health = 200; 
        }

        private int shield = 100;

        public Knight(int hp, int shield, bool alive) : base(hp, alive)
        {
            this.shield = shield;
        }

        public override void DealDamage(Character enemy)
        {
            throw new NotImplementedException();
        }

        public override void TakeDamage(int dmg)
        {
            if(shield >= dmg) //if the shield can tank all the damage
            {
                shield = shield - dmg;
            }
            else if(shield != 0 && shield < dmg)
            {
                dmg = dmg - shield; //reduces the damage by the leftover shield amount
                shield = 0; //"breaks" the shield
                health = health - dmg; //takes the damage off the health
            }
            else //if there is no shield it will take the damage from health
            {
                health = health - dmg;
            }

            //checks if the character is alive after taking damage
            if(health < 1)
            {
                Die();
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" SHIELD: {shield}";
        }
    }
}
