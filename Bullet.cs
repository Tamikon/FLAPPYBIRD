using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FLAPPYBIRD
{
    internal class Bullet : PictureBox
    {
        public static int speed = 40;
        public static int posX;
        public static int posY;

        public Bullet()
        {
            this.Location = new Point(posX, posY);
        }
    }
}
