using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Player
    {
        private Character character;
        private Weapon equippedWeapon;

        public Player(Character character, Weapon equipped)
        {
            this.character = character;
            equippedWeapon = equipped;
        }
    }
}
