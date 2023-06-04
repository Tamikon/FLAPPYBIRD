using FLAPPYBIRD;
using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;

namespace MainMenu
{
    public partial class ChooseLevel : Form
    {
        private StatsClass statsClass = new StatsClass();

        MediaPlayer chooselevel = new MediaPlayer();
        MediaPlayer select = new MediaPlayer();

        FLAPPYBIRD.Menu menu;

        public ChooseLevel()
        {
            select.Open(new Uri(Environment.CurrentDirectory + "\\select.wav"));
            playMusic();
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

        public void playMusic()
        {
            chooselevel.Open(new Uri(Environment.CurrentDirectory + "\\gaming.wav"));
            chooselevel.Play();
        }

        public void lvl1_Click(object sender, EventArgs e)
        {
            select.Play();
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "NoName";
            Battlefield game = new Battlefield(this);
            game.level = 1;
            game.Show();
            chooselevel.Stop();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            select.Play();
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "NoName";
            Battlefield game = new Battlefield(this);
            game.level = 2;
            game.Show();
            chooselevel.Stop();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            select.Play();
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "NoName";
            Battlefield game = new Battlefield(this);
            game.level = 3;
            game.Show();
            chooselevel.Stop();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            chooselevel.Stop();
            menu  = new FLAPPYBIRD.Menu();
            menu.ShowDialog();
            select.Play();

        }
    }
}