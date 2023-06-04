using FLAPPYBIRD;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;

namespace MainMenu
{
    public partial class ChooseLevel : Form
    {
        private StatsClass statsClass = new StatsClass();

        MediaPlayer chooselevel = new MediaPlayer();
        MediaPlayer select = new MediaPlayer();
        public void lvlpusk(int level)
        {
            select.Play();
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "NoName";
            Battlefield game = new Battlefield(this);
            game.level = level;
            game.Show();
            chooselevel.Stop();

        }

        public ChooseLevel()
        {
            select.Open(new Uri(Environment.CurrentDirectory + "\\select.wav"));
            select.Play();
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

        public void lvl1_Click(object sender, EventArgs e) => lvlpusk(1);
        private void lvl2_Click(object sender, EventArgs e) => lvlpusk(2);
        private void lvl3_Click(object sender, EventArgs e) => lvlpusk(3);


        private void EscapeButton_Click(object sender, EventArgs e)
        {
            chooselevel.Stop();
            FLAPPYBIRD.Menu menu = new FLAPPYBIRD.Menu();
            menu.ShowDialog();
            Close();
        }
    }
}