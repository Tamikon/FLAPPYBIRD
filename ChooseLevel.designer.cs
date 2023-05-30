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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLevel));
            this.LevelInput = new System.Windows.Forms.Label();
            this.lvl3 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.Button();
            this.lvl1 = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EscapeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LevelInput
            // 
            this.LevelInput.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LevelInput, 3);
            this.LevelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LevelInput.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelInput.ForeColor = System.Drawing.Color.Snow;
            this.LevelInput.Location = new System.Drawing.Point(231, 180);
            this.LevelInput.Name = "LevelInput";
            this.LevelInput.Size = new System.Drawing.Size(336, 90);
            this.LevelInput.TabIndex = 0;
            this.LevelInput.Text = "Выберите уровень сложности";
            this.LevelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvl3
            // 
            this.lvl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lvl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lvl3.Location = new System.Drawing.Point(573, 273);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(108, 84);
            this.lvl3.TabIndex = 3;
            this.lvl3.Text = "сложный";
            this.lvl3.UseVisualStyleBackColor = false;
            this.lvl3.Click += new System.EventHandler(this.lvl3_Click);
            // 
            // lvl2
            // 
            this.lvl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lvl2.Location = new System.Drawing.Point(345, 273);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(108, 84);
            this.lvl2.TabIndex = 4;
            this.lvl2.Text = "средний";
            this.lvl2.UseVisualStyleBackColor = false;
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            // 
            // lvl1
            // 
            this.lvl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lvl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl1.Location = new System.Drawing.Point(117, 273);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(108, 84);
            this.lvl1.TabIndex = 5;
            this.lvl1.Text = "лёгкий";
            this.lvl1.UseVisualStyleBackColor = false;
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.NameInput, 3);
            this.NameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameInput.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.ForeColor = System.Drawing.Color.Snow;
            this.NameInput.Location = new System.Drawing.Point(231, 0);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(336, 90);
            this.NameInput.TabIndex = 6;
            this.NameInput.Text = "Введите имя";
            this.NameInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nickname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Nickname, 3);
            this.Nickname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nickname.Location = new System.Drawing.Point(231, 93);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(336, 80);
            this.Nickname.TabIndex = 7;
            this.Nickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.EscapeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lvl3, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvl2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lvl1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NameInput, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LevelInput, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Nickname, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // EscapeButton
            // 
            this.EscapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EscapeButton.Location = new System.Drawing.Point(3, 3);
            this.EscapeButton.Name = "EscapeButton";
            this.EscapeButton.Size = new System.Drawing.Size(107, 84);
            this.EscapeButton.TabIndex = 8;
            this.EscapeButton.Text = "Назад";
            this.EscapeButton.UseVisualStyleBackColor = true;
            this.EscapeButton.Click += new System.EventHandler(this.EscapeButton_Click);
            // 
            // ChooseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseLevel";
            this.Text = "Выбор уровня";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LevelInput;
        private System.Windows.Forms.Button lvl3;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.Label NameInput;
        internal System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EscapeButton;
    }
}