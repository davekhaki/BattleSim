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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public Game(Player player1, Player player2)
        {
            InitializeComponent();


            player1CharacterName.Text = player1.GetCharacter().GetType().ToString();
            

            player1text.Text = player1.GetCharacter().ToString();
            player2text.Text = player2.GetCharacter().ToString();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
