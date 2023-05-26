using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO;
using System.Resources;
using System.Collections;
using System.Reflection;
using MainMenu;

namespace FLAPPYBIRD
{
    public partial class Battlefield : Form
    {
        // Здесь начинаются переменные
        int pipeSpeed = 12;// скорость трубы по умолчанию определяется целым числом
        int enemySpeed = 20;
        int gravity = 10;// скорость гравитации по умолчанию определяется целым числом
        public static int score = 0;// целое число баллов по умолчанию установлено равным 0
        public int level = 0;
        bool flag = true;
        public static int finalscore = 0;
        private ChooseLevel chslvl;
        List<Bullet> bullets = new List<Bullet>();


        public Battlefield(ChooseLevel chslvl)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.chslvl = chslvl;
            UserName.Text = "Киберспортсмен: " + chslvl.user;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;// привяжем птичку к гравитации, += означает, что она добавит скорость гравитации к верхнему положению полей с картинками, поэтому она будет двигаться вниз
            pipeBottom.Left -= pipeSpeed;// свяжем левую позицию нижней трубы с целым числом скорости трубы, это уменьшит значение скорости трубы,поэтому она будет двигаться влево с каждым раз
            pipeTop.Left -= pipeSpeed;// то же самое происходит и с верхней трубой, уменьшим значение скорости трубы от левого положения с помощью знака -=
            ground.Left -= pipeSpeed;

            foreach (Bullet pulka in bullets)
            {
                var rand = new Random();
                var randEnemy = rand.Next(0, 380);

                pulka.Left += Bullet.speed;
                if (pulka.Left > Size.Width)
                {
                    /*bullets.Remove(pulka);
                    Controls.Remove(pulka);*/
                }

                if (pulka.Bounds.IntersectsWith(Enemy1.Bounds))
                    Enemy1.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));

                if (pulka.Bounds.IntersectsWith(Enemy2.Bounds))
                    Enemy2.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));

                if (pulka.Bounds.IntersectsWith(Enemy3.Bounds))
                    Enemy3.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));

            }


            if (level >= 2)
            {
                Enemy1.Left -= enemySpeed;
                Enemy2.Left -= enemySpeed;
                Enemy3.Left -= enemySpeed;
            }

            scoreText.Text = "Очки: " + score;
            gravity += 2;

            if (pipeBottom.Left < -150)
            {
                // если расположение нижних труб равно -150, то мы сбросим его обратно на 800 и добавим 1 к счету
                var rand = new Random();
                var randPipe = rand.Next(0, 400);
                var randEnemy = rand.Next(0, 380);
                int midscrean = Size.Height / 2;//Находим центр экрана 
                pipeTop.Location = new Point(Size.Width, midscrean - 1200 + randPipe);//Положение верхней трубы 
                pipeBottom.Location = new Point(Size.Width, pipeTop.Location.Y + 1100);//Положение нижней трубы

                if (level >= 2 && Enemy3.Left < 0)
                {
                    Enemy1.Location = new Point(Size.Width + 200, Size.Height - 700 + rand.Next(0, 380));
                    Enemy2.Location = new Point(Size.Width + 600, Size.Height - 700 + rand.Next(0, 380));
                    Enemy3.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));
                }

                score++;
                if (pipeSpeed < 30)
                {
                    pipeSpeed++;
                    enemySpeed++;
                }
            }

            if (ground.Right < Size.Width + 30) ground.Left = 0;

            // приведенный ниже оператор if проверяет, ударилась ли птичка о землю, трубу или игрок покинул экран сверху
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < 0 ||
                flappyBird.Bounds.IntersectsWith(Enemy1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Enemy2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Enemy3.Bounds))
            {
                // если какое-либо из условий выше, то мы запустим функцию завершения игры

                scoreText.Refresh();// Перезапускаем отрисовку счета очков игры
                endGame();// Проигрыш
                if (MessageBox.Show("На пересдачу", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NewGame();// Перезапуск игры 
                }
                else
                {
                    Battlefield.ActiveForm.Close();
                }
            }
        }

        public void endGame()
        {
            // эта функция завершения игры, эта функция сработает, когда птица коснется земли или труб
            finalscore = score;
            using (StreamWriter statsfile = new StreamWriter(Path.GetFullPath("Stats.txt"), true))
            {
                statsfile.WriteLine(finalscore);
            }
            gameTimer.Stop();// Остановить основной таймер
            flag = true;
            chslvl.score = score;
            chslvl.SaveScore();
            score = 0;
            chslvl.score = 0;
        }

        private void NewGame() //Эта чаcть кода при проигрыше начинает игру заново
        {
            Thread.Sleep(1000);// Игра начнется через 1 секунду

                // Следующий код возвращает все элементы на иходные позиций
            flappyBird.Top = 100;
            pipeBottom.Left = Size.Width;
            pipeTop.Left = Size.Width;

            if (level >= 2)
            {
                var rand = new Random();
                Enemy1.Location = new Point(Size.Width + 200, Size.Height - 700 + rand.Next(0, 380));
                Enemy2.Location = new Point(Size.Width + 600, Size.Height - 700 + rand.Next(0, 380));
                Enemy3.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));
            }

            pipeSpeed = 12;
            enemySpeed = 20;// скорость трубы 
            gravity = 10;// скорость гравитации 
            score = 0;// счет
            gameTimer.Start();// Возобновить основной таймер
        }

        private void gamekeeisdown(object sender, KeyEventArgs e)
        {
            // это событие игровой клавиши нажато, связанное с главной формой; (пробел)
            if (e.KeyCode == Keys.Space && flag == true)
            {
                // если нажата клавиша пробела, то гравитация будет установлена ​​на -6
                gravity = -20;
                flag = false;

                Bullet bullet = new Bullet();
                bullet.Location = flappyBird.Location;
                bullet.Image = Properties.Resources.bird;
                bullets.Add(bullet);
                Controls.Add(bullet);
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // это событие игровая клавиша не нажата, связанное с главной формой; (пробел)
            if (e.KeyCode == Keys.Space)
                flag = true;
        }

        private void Battlefield_Load(object sender, EventArgs e)
        {
            UserName.Text = "Киберспортсмен: " + chslvl.user;
        }

        private void Battlefield_FormClosing(object sender, FormClosingEventArgs e)
        {
            endGame();
        }
    }
}   