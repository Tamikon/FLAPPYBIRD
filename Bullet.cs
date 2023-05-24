using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAPPYBIRD
{
    internal class Bullet
    {
        private int xPos;
        private int yPos;

        private int speed;
        

        public Bullet(int xPos, int yPos) {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public void Tick()
        {
            yPos += speed;
        }

        public Point GetPos()
        {
            return new Point(xPos, yPos);
        }

    }
}
