using System.Windows.Forms;
using System.Drawing;

namespace FLAPPYBIRD
{
    internal class Bullet : PictureBox
    {
        public static int speed = 40;

        public Bullet(PictureBox spawnPlace)
        {
            this.Location = spawnPlace.Location;
            this.Image = Properties.Resources.bullet;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(60, 40);
            this.BackColor = Color.Transparent;
        }
    }
}
