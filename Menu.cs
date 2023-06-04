using MainMenu;
using System;
using System.Media;
using System.Windows.Forms;
using System.Windows.Media;

namespace FLAPPYBIRD
{
    public partial class Menu : Form
    {
        public MediaPlayer menu = new MediaPlayer();
        public MediaPlayer select = new MediaPlayer();
        public Menu()
        {
            InitializeComponent();
            menu.Open(new Uri(Environment.CurrentDirectory + "\\mainmenu.wav"));
            menu.Play();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            menu.Stop();
            ChooseLevel chooseLevel = new ChooseLevel();
            chooseLevel.ShowDialog();
            select.Play();
            this.Close();
        } 

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            new Statistics().Show();
            select.Play();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
