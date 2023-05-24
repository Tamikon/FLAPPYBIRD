using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPYBIRD
{
    public partial class Statistics : Form
    {
        private StatsClass stats;
        private List<Control> myControls = new List<Control> ();
        public Statistics()
        {
            InitializeComponent();
            stats = new StatsClass();
            if(stats.Names.Count > 0)
            {
                drawStats();
                this.AutoScroll = true;
            }
            else
                EmptyLabel.Visible = true;

        //    var bt = new Button()
        //    {
        //        Text = "Назад",
        //        Location = new Point(10, 10),
        //        Height = 45,
        //        ForeColor=Color.White,
        //    };
        //    bt.Click += WindowClose;
            
        //    Controls.Add(bt);
        }

        //Обработчик кнопки для закрытия окна статистики
        private void WindowClose(object sender, EventArgs e)
        {
            this.Close();
        }

        //Обработчик кнопки для очистки статистики
        private void ResetStats(object sender, EventArgs e)
        {
            //foreach(var item in myControls)
            //{
            //    Controls.Remove(item);
            //    myControls.Remove(item);
            //    item.Dispose();
            //}
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
                var cnt = new Label() { Width = 400, Text = item, Location = new Point(10, i), Height = 50, ForeColor=Color.White, Font = new Font(new FontFamily("MV Boli"), 30)};
                myControls.Add(cnt);
                Controls.Add(cnt);
                i += 55;
            }

            i = 55;
            foreach(var item in stats.Scores)
            {
                var cnt = new Label() { Text = item, Location = new Point(450, i), Height = 50, ForeColor = Color.Red, Font = new Font(new FontFamily("MV Boli"), 30), };
                myControls.Add(cnt);
                Controls.Add(cnt);
                i += 55;
            }
        }


    }
}
