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
        public SoundPlayer startmenu = new SoundPlayer(FLAPPYBIRD.Properties.Resources.mainmenu);
        public SoundPlayer chooselevel = new SoundPlayer(FLAPPYBIRD.Properties.Resources.gaming);

        public SoundPlayer soundlvl1 = new SoundPlayer(FLAPPYBIRD.Properties.Resources.level1);
        public SoundPlayer soundlvl2 = new SoundPlayer(FLAPPYBIRD.Properties.Resources.level2);
        public SoundPlayer soundlvl3 = new SoundPlayer(FLAPPYBIRD.Properties.Resources.level3);


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


        public void lvl1_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 1;
            soundlvl1.PlayLooping();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 2;
            soundlvl2.PlayLooping();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            if (Nickname.Text != "" && !Nickname.Text.Contains(" "))
                user = Nickname.Text;
            else user = "Незнакомец";
            Battlefield game = new Battlefield(this);
            game.Show();
            game.level = 3;
            soundlvl3.PlayLooping();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            startmenu.PlayLooping();
        }
    }
}
