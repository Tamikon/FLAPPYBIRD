using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;

namespace FLAPPYBIRD
{
    public partial class Statistics : Form
    {
        private StatsClass stats;
        private List<Control> myControls = new List<Control> ();
        private MediaPlayer select = new MediaPlayer();

        public Statistics()
        {
            InitializeComponent();
            select.Open(new Uri(Environment.CurrentDirectory + "\\select.wav"));
            select.Play();
            stats = new StatsClass();
            if(stats.Names.Count > 0)
            {
                drawStats();
                this.AutoScroll = true;
            }
            else
                EmptyLabel.Visible = true;
        }

        //Обработчик кнопки для закрытия окна статистики
        private void WindowClose(object sender, EventArgs e)
        {
            this.Close();
        }

        //Обработчик кнопки для очистки статистики
        private void ResetStats(object sender, EventArgs e)
        {
            for(int i = myControls.Count - 1; i >= 0; i--) {
                Controls.Remove(myControls[i]);
                myControls[i].Dispose();
                myControls.RemoveAt(i);
            }
            stats.ResetStats();
            GC.Collect();
            EmptyLabel.Visible = true;
        }

        //Функция для отрисовки статистики
        private void drawStats()
        {
            int i = 55;
            foreach (var item in stats.Names)
            {
                var cnt = new Label() { Width = 400, Text = item, Location = new Point(10, i), 
                    Height = 50, ForeColor=System.Drawing.Color.White, Font = new Font(new System.Drawing.FontFamily("MV Boli"), 30)};
                myControls.Add(cnt);
                Controls.Add(cnt);
                i += 55;
            }

            i = 55;
            foreach(var item in stats.Scores)
            {
                var cnt = new Label() { Text = item, Location = new Point(450, i), 
                    Height = 50, ForeColor = System.Drawing.Color.Red, Font = new Font(new System.Drawing.FontFamily("MV Boli"), 30), };
                myControls.Add(cnt);
                Controls.Add(cnt);
                i += 55;
            }
        }


    }
}
