using FLAPPYBIRD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class ChooseLevel : Form
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            Battlefield game = new Battlefield();
            game.Show();

            if (game.score == 2)
            {
                game.endGame();
                MessageBox.Show("Уровень пройден!");
            }
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            Battlefield game = new Battlefield();
            game.Show();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            Battlefield game = new Battlefield();
            game.Show();
        }
    }
}
