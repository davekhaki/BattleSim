using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleSim
{
    public class Player
    {
        private Character.Character character;
        private Weapon.Weapon equippedWeapon;

        public Player(Character.Character character, Weapon.Weapon equipped)
        {
            this.character = character;
            equippedWeapon = equipped;
        }

        public Character.Character GetCharacter()
        {
            return character;
        }

    }
}
