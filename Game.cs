using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MainMenu;


namespace FLAPPYBIRD
{
    public partial class Battlefield : Form
    {
        // Здесь начинаются переменные
        private int pipeSpeed = 12;// скорость трубы 
        private int enemySpeed = 20;// скорость врагов
        private int gravity = 10;// скорость гравитации 
        private bool flag = true;
        bool beginFlag = false;
        public int level = 0; 
        public static int score = 0;// целое число баллов по умолчанию установлено равным 0
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

        private void Enemysp()//Спаун врагов
        {
            var rand = new Random();
            Enemy1.Location = new Point(Size.Width + 200, Size.Height - 700 + rand.Next(0, 380));
            Enemy2.Location = new Point(Size.Width + 600, Size.Height - 700 + rand.Next(0, 380));
            Enemy3.Location = new Point(Size.Width + 1000, Size.Height - 700 + rand.Next(0, 380));
        }

        private void Bulletdamage()//Урон от пуль 
        {
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
                {
                    Enemy1.Location = new Point(Size.Width, Size.Height - 700 + rand.Next(0, 380));
                    score++;
                }

                if (pulka.Bounds.IntersectsWith(Enemy2.Bounds))
                {
                    Enemy2.Location = new Point(Size.Width, Size.Height - 700 + rand.Next(0, 380));
                    score++;
                }
                  
                if (pulka.Bounds.IntersectsWith(Enemy3.Bounds))
                {
                    Enemy3.Location = new Point(Size.Width, Size.Height - 700 + rand.Next(0, 380));
                    score++;
                }
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;// привяжем птичку к гравитации, += означает, что она добавит скорость гравитации к верхнему положению полей с картинками, поэтому она будет двигаться вниз
            pipeBottom.Left -= pipeSpeed;// свяжем левую позицию нижней трубы с целым числом скорости трубы, это уменьшит значение скорости трубы,поэтому она будет двигаться влево с каждым раз
            pipeTop.Left -= pipeSpeed;// то же самое происходит и с верхней трубой, уменьшим значение скорости трубы от левого положения с помощью знака -=
            ground.Left -= pipeSpeed;

            if (level >= 2)
            {
                Enemy1.Left -= enemySpeed;
                Enemy2.Left -= enemySpeed;
                Enemy3.Left -= enemySpeed;
            }

            Bulletdamage();

            if (level == 3 && beginFlag == false)
            {
                Enemy1.Size = new Size(100, 70);
                Enemy2.Size = new Size(100, 70);
                Enemy3.Size = new Size(100, 70);
                enemySpeed = 30;
                beginFlag = true;
            }

            scoreText.Text = "Очки: " + score;
            gravity += 2;

            if (pipeBottom.Left < -120)//если положение нижней трубы -120 то телепортируем трубы вперед 
            {
                var rand = new Random();
                var randPipe = rand.Next(0, 400);
                var randEnemy = rand.Next(0, 380);
                int midscrean = Size.Height / 2;//Находим центр экрана 
                pipeTop.Location = new Point(Size.Width, midscrean - 1200 + randPipe);//Положение верхней трубы 
                pipeBottom.Location = new Point(Size.Width, pipeTop.Location.Y + 1100);//Положение нижней трубы

                if (Enemy1.Left < 0 && Enemy2.Left < 0 && Enemy3.Left < 0)//телепортируем врагов вперед
                {
                    Enemysp();
                }

                score++;
                if (pipeSpeed < 30)//ускоряем игру 
                {
                    pipeSpeed++;
                    enemySpeed++;
                }
            }
            if (ground.Right < Size.Width + 30) ground.Left = 0;

            // приведенный ниже оператор if проверяет, ударилась ли птичка о землю, трубу или игрок покинул экран сверху или задел врага
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

        private void endGame()
        {
            // эта функция завершения игры, эта функция сработает, когда птица коснется земли или труб
            finalscore = score;
            using (StreamWriter statsfile = new StreamWriter(Path.GetFullPath("Stats.txt"), true))
            {
                statsfile.WriteLine(finalscore);
            }
            gameTimer.Stop();// Остановить основной таймер
            flag = true;
            beginFlag = false;
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
                Enemysp();
            }
            pipeSpeed = 12;// скорость трубы
            enemySpeed = 20;// скорость врагов
            gravity = 10;// скорость гравитации 
            score = 0;// счет
            gameTimer.Start();// Возобновить основной таймер
        }

        private void gamekeeisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && flag == true)
            {
                gravity = -20;
                flag = false;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
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

        private void Battlefield_MouseDown(object sender, MouseEventArgs e)
        {
            Bullet bullet = new Bullet(flappyBird);
            bullets.Add(bullet);
            Controls.Add(bullet);
        }
    }
}   