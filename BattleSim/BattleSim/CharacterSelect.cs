using BattleSim.Character;
using BattleSim.Weapon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleSim
{
    public partial class CharacterSelect : Form
    {
        public CharacterSelect()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Player player1 = null;
            Player player2 = null;

            switch (player1CharacterChoose.Text)
            {
                case "Knight":
                    player1 = new Player(new Knight(200, 100, true), new Sword(50, 0.1, 0.1));
                    break;
                case "Wizard":
                    player1 = new Player(new Wizard(150, 500, true), new IceStaff(75, 0.1, 0.1, 75));
                    break;
            }

            switch (player2CharacterChoose.Text)
            {
                case "Knight":
                    player2 = new Player(new Knight(200, 100, true), new Sword(50, 0.1, 0.1));
                    break;

                case "Wizard":
                    player2 = new Player(new Wizard(150, 500, true), new IceStaff(75, 0.1, 0.1, 75));
                    break;
            }

            Game game = new Game(player1, player2);
            this.Hide();
            game.Show();
        }
    }
}
