namespace FLAPPYBIRD
{
    partial class Statistics
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
            this.EscapeStats = new System.Windows.Forms.Button();
            this.ClearStats = new System.Windows.Forms.Button();
            this.EmptyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EscapeStats
            // 
            this.EscapeStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EscapeStats.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EscapeStats.Location = new System.Drawing.Point(637, 12);
            this.EscapeStats.Name = "EscapeStats";
            this.EscapeStats.Size = new System.Drawing.Size(151, 51);
            this.EscapeStats.TabIndex = 0;
            this.EscapeStats.Text = "Назад";
            this.EscapeStats.UseVisualStyleBackColor = true;
            this.EscapeStats.Click += new System.EventHandler(this.WindowClose);
            // 
            // ClearStats
            // 
            this.ClearStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearStats.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearStats.Location = new System.Drawing.Point(637, 69);
            this.ClearStats.Name = "ClearStats";
            this.ClearStats.Size = new System.Drawing.Size(151, 51);
            this.ClearStats.TabIndex = 1;
            this.ClearStats.Text = "Очистить статистику";
            this.ClearStats.UseVisualStyleBackColor = true;
            this.ClearStats.Click += new System.EventHandler(this.ResetStats);
            // 
            // EmptyLabel
            // 
            this.EmptyLabel.AutoSize = true;
            this.EmptyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmptyLabel.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLabel.Location = new System.Drawing.Point(0, 0);
            this.EmptyLabel.Name = "EmptyLabel";
            this.EmptyLabel.Size = new System.Drawing.Size(243, 85);
            this.EmptyLabel.TabIndex = 2;
            this.EmptyLabel.Text = "Пусто";
            this.EmptyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmptyLabel.Visible = false;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmptyLabel);
            this.Controls.Add(this.ClearStats);
            this.Controls.Add(this.EscapeStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EscapeStats;
        private System.Windows.Forms.Button ClearStats;
        private System.Windows.Forms.Label EmptyLabel;
    }
}