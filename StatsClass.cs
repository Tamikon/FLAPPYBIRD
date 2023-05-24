using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace FLAPPYBIRD
{
    /// <summary>
    /// Класс отвечающий за статистику
    /// </summary>
    public class StatsClass
    {
        private List<string> names = new List<string>();
        private List<string> scores = new List<string>();

        private string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Stats.txt";

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public StatsClass()
        {
            StatUpdate();
        }

        /// <summary>
        /// Получение списка Ников
        /// </summary>
        public List<string> Names { get { return this.names; } }

        /// <summary>
        /// Получение списка очков
        /// </summary>
        public List<string> Scores { get { return this.scores; } }

        /// <summary>
        /// Сброс статистики
        /// </summary>
        public void ResetStats()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Stats.txt");
            this.names.Clear();
            this.scores.Clear();
        }

        /// <summary>
        /// Добавление в статистику
        /// </summary>
        /// <param name="name">Ник</param>
        /// <param name="score">Очки</param>
        public void AddStat(string name, string score)
        {
            this.names.Add(name);
            this.scores.Add(score);
            SaveStats();
        }

        /// <summary>
        /// Добавление в статистику
        /// </summary>
        /// <param name="name">Ник</param>
        /// <param name="score">Очки</param>
        public void AddStat(string name, int score)
        {
            this.names.Add(name);
            this.scores.Add(score.ToString());
            SaveStats();
        }

        /// <summary>
        /// Сохранение статистики
        /// </summary>
        private void SaveStats()
        {
            File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Stats.txt");
            StreamWriter f = new StreamWriter(path, true);
            for (int i = 0; i < this.names.Count; i++)
            {
                string outText = this.names[i]+" "+this.scores[i];
                f.WriteLine(outText);
            }
            f.Close();
        }

        /// <summary>
        /// Обновление статистики. Считывает статистику с файла.
        /// </summary>
        public void StatUpdate()
        {
            if (File.Exists(path))
            {
                StreamReader streamReader = new StreamReader(path);
                while (!streamReader.EndOfStream)
                {
                    string[] strings = streamReader.ReadLine().Split(' ');
                    names.Add(strings[0]);
                    scores.Add(strings[1]);
                }
                streamReader.Close();
            }
        }
    }
}
