using FLAPPYBIRD;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class ChooseLevel : Form
    {
        private StatsClass statsClass = new StatsClass();

        public SoundPlayer chooselevel = new SoundPlayer(FLAPPYBIRD.Properties.Resources.gaming);
        public SoundPlayer menu = new SoundPlayer(FLAPPYBIRD.Properties.Resources.mainmenu);


        public ChooseLevel()
        {
            InitializeComponent();
            playMusic();
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

        public void playMusic()
        {
            chooselevel.PlayLooping();
        }

        public void lvl1_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.level = 1;
            game.Show();
            chooselevel.Stop();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.level = 2;
            game.Show();
            chooselevel.Stop();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.level = 3;
            game.Show();
            chooselevel.Stop();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.PlayLooping();

        }
    }
}