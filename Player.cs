using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLAPPYBIRD
{
    internal class Player
    {
        private int xPos;
        private int yPos;
        private int gravity = 10;
        private List<Bullet> Bullets = new List<Bullet>();
        public Player(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public void Tick()
        {
            this.yPos += gravity;
            foreach(var bullet in Bullets)
            {
                bullet.Tick();
            }
        }

        public void Jump()
        {
            this.yPos -= gravity;
        }

        public void Shoot()
        {
            Bullets.Add(new Bullet(this.xPos, this.yPos));
        }

        public Point GetPoint()
        {
            return new Point(xPos, yPos);
        }
    }
}