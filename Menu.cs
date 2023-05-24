using MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPYBIRD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
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
