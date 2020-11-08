using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim.Character
{
    public class Wizard : Character
    {
        protected override int health
        {
            get => base.health;
            set => base.health = 50;
        }

        private int mana = 500;

        public Wizard(int hp, int mana, bool alive) : base(hp, alive)
        {
            this.mana = mana;
        }

        public override string ToString()
        {
            return base.ToString() + $" MANA: {mana}";
        }
    }
}
