namespace MemoryGame
{
    partial class Highscores
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
            this.button1 = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dif1 = new System.Windows.Forms.RadioButton();
            this.dif2 = new System.Windows.Forms.RadioButton();
            this.dif3 = new System.Windows.Forms.RadioButton();
            this.dif4 = new System.Windows.Forms.RadioButton();
            this.dif5 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(31, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Scores
            // 
            this.Scores.AutoSize = true;
            this.Scores.BackColor = System.Drawing.Color.Transparent;
            this.Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores.ForeColor = System.Drawing.Color.White;
            this.Scores.Location = new System.Drawing.Point(29, 120);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(92, 31);
            this.Scores.TabIndex = 21;
            this.Scores.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.dif1);
            this.flowLayoutPanel1.Controls.Add(this.dif2);
            this.flowLayoutPanel1.Controls.Add(this.dif3);
            this.flowLayoutPanel1.Controls.Add(this.dif4);
            this.flowLayoutPanel1.Controls.Add(this.dif5);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(729, 44);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // dif1
            // 
            this.dif1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif1.AutoSize = true;
            this.dif1.Checked = true;
            this.dif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif1.Location = new System.Drawing.Point(3, 3);
            this.dif1.Name = "dif1";
            this.dif1.Size = new System.Drawing.Size(157, 41);
            this.dif1.TabIndex = 0;
            this.dif1.TabStop = true;
            this.dif1.Text = "Very Easy";
            this.dif1.UseVisualStyleBackColor = true;
            this.dif1.CheckedChanged += new System.EventHandler(this.dif1_CheckedChanged);
            // 
            // dif2
            // 
            this.dif2.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif2.AutoSize = true;
            this.dif2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif2.Location = new System.Drawing.Point(166, 3);
            this.dif2.Name = "dif2";
            this.dif2.Size = new System.Drawing.Size(89, 41);
            this.dif2.TabIndex = 1;
            this.dif2.Text = "Easy";
            this.dif2.UseVisualStyleBackColor = true;
            this.dif2.CheckedChanged += new System.EventHandler(this.dif2_CheckedChanged);
            // 
            // dif3
            // 
            this.dif3.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif3.AutoSize = true;
            this.dif3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif3.Location = new System.Drawing.Point(261, 3);
            this.dif3.Name = "dif3";
            this.dif3.Size = new System.Drawing.Size(117, 41);
            this.dif3.TabIndex = 2;
            this.dif3.Text = "Normal";
            this.dif3.UseVisualStyleBackColor = true;
            this.dif3.CheckedChanged += new System.EventHandler(this.dif3_CheckedChanged);
            // 
            // dif4
            // 
            this.dif4.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif4.AutoSize = true;
            this.dif4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif4.Location = new System.Drawing.Point(384, 3);
            this.dif4.Name = "dif4";
            this.dif4.Size = new System.Drawing.Size(87, 41);
            this.dif4.TabIndex = 3;
            this.dif4.Text = "Hard";
            this.dif4.UseVisualStyleBackColor = true;
            this.dif4.CheckedChanged += new System.EventHandler(this.dif4_CheckedChanged);
            // 
            // dif5
            // 
            this.dif5.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif5.AutoSize = true;
            this.dif5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dif5.Location = new System.Drawing.Point(477, 3);
            this.dif5.Name = "dif5";
            this.dif5.Size = new System.Drawing.Size(131, 41);
            this.dif5.TabIndex = 4;
            this.dif5.Text = "Extreme";
            this.dif5.UseVisualStyleBackColor = true;
            this.dif5.CheckedChanged += new System.EventHandler(this.dif5_CheckedChanged);
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.Memorygame_players;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Highscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Scores;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton dif1;
        private System.Windows.Forms.RadioButton dif2;
        private System.Windows.Forms.RadioButton dif3;
        private System.Windows.Forms.RadioButton dif4;
        private System.Windows.Forms.RadioButton dif5;
    }
}