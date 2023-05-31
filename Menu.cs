using MainMenu;
using System;
using System.Media;
using System.Windows.Forms;

namespace FLAPPYBIRD
{
    public partial class Menu : Form
    {
        public SoundPlayer startmenu = new SoundPlayer(Properties.Resources.mainmenu);
        public SoundPlayer chooselevel = new SoundPlayer(Properties.Resources.gaming);

        public Menu()
        {
            InitializeComponent();
            startmenu.PlayLooping();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            chooselevel.PlayLooping();
            ChooseLevel chooseLevel = new ChooseLevel();
            chooseLevel.ShowDialog();
        } 

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
