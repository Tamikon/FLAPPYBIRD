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
        private StatsClass statsClass = new StatsClass();
        public ChooseLevel()
        {
            InitializeComponent();
        }

        public string user;
        public int score;

        public void SaveScore()
        {
            using (StreamWriter statsfile = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Stats.txt", true))
            {
                statsfile.Write(user + " " + score + "\n");
                statsfile.Close();
            }
            statsClass.AddStat(user, score);
        }


        private void lvl1_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Дэбилоид";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 1;
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Дэбилоид";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 2;
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Дэбилоид";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 3;
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
