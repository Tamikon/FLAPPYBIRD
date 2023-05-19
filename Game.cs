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

namespace FLAPPYBIRD
{
    public partial class Battlefield : Form
    {
        // Здесь начинаются переменные
        int pipeSpeed = 12;// скорость трубы по умолчанию определяется целым числом
        int gravity = 10;// скорость гравитации по умолчанию определяется целым числом
        public int score = 0;// целое число баллов по умолчанию установлено равным 0
        bool flag = true;

        public Battlefield()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;// привяжем птичку к гравитации, += означает, что она добавит скорость гравитации к верхнему положению полей с картинками, поэтому она будет двигаться вниз
            pipeBottom.Left -= pipeSpeed;// свяжем левую позицию нижней трубы с целым числом скорости трубы, это уменьшит значение скорости трубы,поэтому она будет двигаться влево с каждым раз
            pipeTop.Left -= pipeSpeed;// то же самое происходит и с верхней трубой, уменьшим значение скорости трубы от левого положения с помощью знака -=
            ground.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;// показать текущий счет 
            gravity += 2;

            if (pipeBottom.Left < -150)  
            {
                // если расположение нижних труб равно -150, то мы сбросим его обратно на 800 и добавим 1 к счету
                var rand = new Random();
                var randY = rand.Next(0, 400);
                pipeBottom.Location = new Point(Size.Width, Size.Height - 700 + randY);
                pipeTop.Location = new Point(Size.Width, - 750 + randY);
                score++;
                 if (pipeSpeed < 30) pipeSpeed += 1;
            }

            if (ground.Right < Size.Width + 30) ground.Left = 0;

            // приведенный ниже оператор if проверяет, ударилась ли птичка о землю, трубу или игрок покинул экран сверху
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < 0)

            {
                // если какое-либо из условий выше, то мы запустим функцию завершения игры
                scoreText.Text += " Game over!!!";// показать игру поверх текста в тексте счета
                scoreText.Refresh();// Перезапускаем отрисовку счета очков игры
                endGame();// Проигрыш
                NewGame();// Перезапуск игры 
            }
        }

        public void endGame()
        {
            // эта функция завершения игры, эта функция сработает, когда птица коснется земли или труб

            gameTimer.Stop();// Остановить основной таймер
            flag = true;
        }

        private void NewGame() //Эта чать кода при проигрыше начинает игру заново
        {
            MessageBox.Show("На пересдачу");
            Thread.Sleep(1000);// Игра начнется через 1 секунду
            // Следующий код возвращает все элементы на иходные позиций
            flappyBird.Top = 100;
            pipeBottom.Left = Size.Width;
            pipeTop.Left = Size.Width;

            pipeSpeed = 12;// скорость трубы 
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
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // это событие игровая клавиша не нажата, связанное с главной формой; (пробел)
            if (e.KeyCode == Keys.Space)
                flag = true;
        }
    }
}   