using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MainMenu;
using System.Media;
using System.Windows.Media;

namespace FLAPPYBIRD
{
    public partial class Battlefield : Form
    {
        // Здесь начинаются переменные
        private int pipeSpeed = 17;// скорость трубы 
        private int enemySpeed = 20;// скорость врагов
        private int gravity = 10;// скорость гравитации 
        private bool flag = true;
        bool beginFlag = false;
        public int level = 0; 
        public static int score = 0;// целое число баллов по умолчанию установлено равным 0
        public static int finalscore = 0;
        private ChooseLevel chslvl;
        List<Bullet> bullets = new List<Bullet>();

        public MediaPlayer mediaPlayer = new MediaPlayer();
        public MediaPlayer shooting = new MediaPlayer();
        
        private MediaPlayer fail = new MediaPlayer();

        public Battlefield(ChooseLevel chslvl)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.chslvl = chslvl;
            UserName.Text = "Киберспортсмен: " + chslvl.user;
            
            
            //C:\Program Files(x86)\Reference Assemblies\Microsoft\Framework.NETFramework\v4.5
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
            //todo: поменять на FOR
            foreach (Bullet pulka in bullets)
            {
                var rand = new Random();
                var randEnemy = rand.Next(0, 380);                
                pulka.Left += Bullet.speed;
                if (pulka.Left > Size.Width)
                {
                    //todo: удалять по индексу RemoveAt
                    //bullets.Remove(pulka);
                    //Controls.Remove(pulka);
                    //GC.Collect();
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

                //todo: при попадании по врагу также удалять пули и врагов
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
                enemySpeed = 33;
                pipeSpeed = 25;
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
                if (pipeSpeed < 50)//ускоряем игру 
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
            mediaPlayer.Stop();
            fail.Open(new Uri(Environment.CurrentDirectory + "\\lose.wav"));
            fail.Play();
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

        private void RestartSound()
        {
            mediaPlayer.Stop();
            if (level == 1) mediaPlayer.Open(new Uri(Environment.CurrentDirectory + "\\level1.wav"));
            else if (level == 2) mediaPlayer.Open(new Uri(Environment.CurrentDirectory + "\\level2.wav"));
            else if (level == 3) mediaPlayer.Open(new Uri(Environment.CurrentDirectory + "\\level3.wav"));
            mediaPlayer.Play();
        }

        private void NewGame() //Эта чаcть кода при проигрыше начинает игру заново
        {
            Thread.Sleep(1000);// Игра начнется через 1 секунду
            RestartSound();
          
            // Следующий код возвращает все элементы на иходные позиций
            fail.Stop();
            flappyBird.Top = 100;
            pipeBottom.Left = Size.Width;
            pipeTop.Left = Size.Width;
            pipeSpeed = 12;// скорость трубы
            enemySpeed = 20;// скорость врагов
            gravity = 10;// скорость гравитации 
            score = 0;// счет

            if (level >= 2) Enemysp();
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
            RestartSound();
        }

        private void Battlefield_FormClosing(object sender, FormClosingEventArgs e)
        {
            endGame();
            fail.Stop();
            fail.Close();
            mediaPlayer.Stop();
            mediaPlayer.Close();
            chslvl.playMusic();
        }


        //todo: сделать кд для выстрелов
        private void Battlefield_MouseDown(object sender, MouseEventArgs e)
        {
            if(level >= 2)
            {
                Bullet bullet = new Bullet(flappyBird);
                shooting.Open(new Uri(Environment.CurrentDirectory + "\\shoot.wav"));
                shooting.Play();
                bullets.Add(bullet);
                Controls.Add(bullet);
            }
        }
    }
}   