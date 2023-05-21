namespace MainMenu
{
    partial class ChooseLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lvl3 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.Button();
            this.lvl1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "выберите уровень";
            // 
            // lvl3
            // 
            this.lvl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lvl3.Location = new System.Drawing.Point(544, 121);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(147, 140);
            this.lvl3.TabIndex = 3;
            this.lvl3.Text = "3";
            this.lvl3.UseVisualStyleBackColor = true;
            this.lvl3.Click += new System.EventHandler(this.lvl3_Click);
            // 
            // lvl2
            // 
            this.lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.lvl2.Location = new System.Drawing.Point(312, 121);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(147, 140);
            this.lvl2.TabIndex = 4;
            this.lvl2.Text = "2";
            this.lvl2.UseVisualStyleBackColor = true;
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            // 
            // lvl1
            // 
            this.lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl1.Location = new System.Drawing.Point(86, 121);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(147, 140);
            this.lvl1.TabIndex = 5;
            this.lvl1.Text = "1";
            this.lvl1.UseVisualStyleBackColor = true;
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FLAPPYBIRD.Properties.Resources.pipe;
            this.pictureBox1.Location = new System.Drawing.Point(340, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FLAPPYBIRD.Properties.Resources.pipe;
            this.pictureBox2.Location = new System.Drawing.Point(111, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FLAPPYBIRD.Properties.Resources.pipe;
            this.pictureBox3.Location = new System.Drawing.Point(572, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 191);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl3);
            this.Controls.Add(this.label1);
            this.Name = "ChooseLevel";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lvl3;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}