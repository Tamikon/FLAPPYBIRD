using System;
using System.Drawing;
using System.Windows.Forms;

namespace FLAPPYBIRD
{
    public class Enemy : PictureBox //todo: класс Enemy либо задействовать либо удалить
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
