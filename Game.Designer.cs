namespace FLAPPYBIRD
{
    partial class Battlefield
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battlefield));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Moccasin;
            this.scoreText.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreText.Location = new System.Drawing.Point(12, 916);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(105, 28);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.BackColor = System.Drawing.Color.Moccasin;
            this.UserName.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.UserName.Location = new System.Drawing.Point(12, 953);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(228, 28);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "Киберспортсмен:";
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::FLAPPYBIRD.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(1920, -400);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(150, 900);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FLAPPYBIRD.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-4, 862);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(3454, 243);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::FLAPPYBIRD.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(1920, 750);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(150, 900);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::FLAPPYBIRD.Properties.Resources.hero;
            this.flappyBird.Location = new System.Drawing.Point(77, 117);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(76, 55);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enemy3.Image = global::FLAPPYBIRD.Properties.Resources.enemy;
            this.Enemy3.Location = new System.Drawing.Point(2230, 554);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(76, 55);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 6;
            this.Enemy3.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enemy2.Image = global::FLAPPYBIRD.Properties.Resources.enemy;
            this.Enemy2.Location = new System.Drawing.Point(2030, 234);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(76, 55);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 7;
            this.Enemy2.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enemy1.Image = global::FLAPPYBIRD.Properties.Resources.enemy;
            this.Enemy1.Location = new System.Drawing.Point(1930, 50);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(76, 55);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 5;
            this.Enemy1.TabStop = false;
            // 
            // Battlefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1904, 1117);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Battlefield";
            this.Text = "Flappy Bird";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battlefield_FormClosing);
            this.Load += new System.EventHandler(this.Battlefield_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeeisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeBottom;
        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.Label UserName;
    }
}

