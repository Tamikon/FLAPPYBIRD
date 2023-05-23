using FLAPPYBIRD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MainMenu
{
    public partial class ChooseLevel : Form
    {
        public ChooseLevel()
        {
            InitializeComponent();
        }

        public static string user;

        private void lvl1_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "")
            {
                Battlefield game = new Battlefield();
                game.Show();
                game.level = 1;
            }
            else MessageBox.Show("Имя введи.");
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "")
            {
                Battlefield game = new Battlefield();
                game.Show();
                game.level = 2;
            }
            else MessageBox.Show("Имя введи.");
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "")
            {
                Battlefield game = new Battlefield();
                game.Show();
                game.level = 3;
            }
            else MessageBox.Show("Имя введи.");
        }

        private void Nickname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (StreamWriter statsfile = new StreamWriter("C:\\Users\\richi\\source\\repos\\GITHUB\\Resources\\Stats.txt", true))
                {
                    user = Nickname.Text;
                    statsfile.WriteLine(Nickname.Text);
                    statsfile.Close();
                }
            }
        }
    }
}
