using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using FLAPPYBIRD;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace FLAPPYBIRD
{
    public class Enemy : PictureBox
    {
        int enemySpeed = 20;
        Point location;
        Random rand = new Random();

        public Enemy()
        {
            this.Location = new Point(Size.Width + 200, Size.Height - 700 + rand.Next(0, 380));
        }
    }
}
