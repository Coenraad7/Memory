﻿namespace MemoryGame
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            this.score1txt = new System.Windows.Forms.Label();
            this.undorotate = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.player1txt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player4txt = new System.Windows.Forms.Label();
            this.score4txt = new System.Windows.Forms.Label();
            this.player3txt = new System.Windows.Forms.Label();
            this.score3txt = new System.Windows.Forms.Label();
            this.player2txt = new System.Windows.Forms.Label();
            this.score2txt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.txtresult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.arrow4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).BeginInit();
            this.SuspendLayout();
            // 
            // score1txt
            // 
            this.score1txt.AutoSize = true;
            this.score1txt.BackColor = System.Drawing.Color.White;
            this.score1txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1txt.Location = new System.Drawing.Point(27, 36);
            this.score1txt.Name = "score1txt";
            this.score1txt.Size = new System.Drawing.Size(56, 15);
            this.score1txt.TabIndex = 16;
            this.score1txt.Text = "Score: 0";
            // 
            // undorotate
            // 
            this.undorotate.Interval = 400;
            this.undorotate.Tick += new System.EventHandler(this.undorotate_Tick);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(1089, 363);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(158, 51);
            this.reset.TabIndex = 17;
            this.reset.Text = "Reset Game";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(1089, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1txt
            // 
            this.player1txt.AutoSize = true;
            this.player1txt.BackColor = System.Drawing.Color.White;
            this.player1txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1txt.Location = new System.Drawing.Point(26, 23);
            this.player1txt.Name = "player1txt";
            this.player1txt.Size = new System.Drawing.Size(98, 15);
            this.player1txt.TabIndex = 19;
            this.player1txt.Text = "Name Player 1:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(165, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 611);
            this.panel1.TabIndex = 20;
            // 
            // player4txt
            // 
            this.player4txt.AutoSize = true;
            this.player4txt.BackColor = System.Drawing.Color.White;
            this.player4txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4txt.Location = new System.Drawing.Point(984, 586);
            this.player4txt.Name = "player4txt";
            this.player4txt.Size = new System.Drawing.Size(98, 15);
            this.player4txt.TabIndex = 22;
            this.player4txt.Text = "Name Player 4:";
            // 
            // score4txt
            // 
            this.score4txt.AutoSize = true;
            this.score4txt.BackColor = System.Drawing.Color.White;
            this.score4txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score4txt.Location = new System.Drawing.Point(985, 599);
            this.score4txt.Name = "score4txt";
            this.score4txt.Size = new System.Drawing.Size(56, 15);
            this.score4txt.TabIndex = 21;
            this.score4txt.Text = "Score: 0";
            // 
            // player3txt
            // 
            this.player3txt.AutoSize = true;
            this.player3txt.BackColor = System.Drawing.Color.White;
            this.player3txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3txt.Location = new System.Drawing.Point(27, 586);
            this.player3txt.Name = "player3txt";
            this.player3txt.Size = new System.Drawing.Size(98, 15);
            this.player3txt.TabIndex = 24;
            this.player3txt.Text = "Name Player 3:";
            // 
            // score3txt
            // 
            this.score3txt.AutoSize = true;
            this.score3txt.BackColor = System.Drawing.Color.White;
            this.score3txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score3txt.Location = new System.Drawing.Point(28, 599);
            this.score3txt.Name = "score3txt";
            this.score3txt.Size = new System.Drawing.Size(56, 15);
            this.score3txt.TabIndex = 23;
            this.score3txt.Text = "Score: 0";
            // 
            // player2txt
            // 
            this.player2txt.AutoSize = true;
            this.player2txt.BackColor = System.Drawing.Color.White;
            this.player2txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2txt.Location = new System.Drawing.Point(984, 23);
            this.player2txt.Name = "player2txt";
            this.player2txt.Size = new System.Drawing.Size(98, 15);
            this.player2txt.TabIndex = 26;
            this.player2txt.Text = "Name Player 2:";
            // 
            // score2txt
            // 
            this.score2txt.AutoSize = true;
            this.score2txt.BackColor = System.Drawing.Color.White;
            this.score2txt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2txt.Location = new System.Drawing.Point(985, 36);
            this.score2txt.Name = "score2txt";
            this.score2txt.Size = new System.Drawing.Size(56, 15);
            this.score2txt.TabIndex = 25;
            this.score2txt.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.BackColor = System.Drawing.Color.Transparent;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(1084, 241);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(0, 26);
            this.txtresult.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1089, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 51);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save Game";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // arrow1
            // 
            this.arrow1.BackColor = System.Drawing.Color.Transparent;
            this.arrow1.Image = global::MemoryGame.Properties.Resources.arrow_up;
            this.arrow1.Location = new System.Drawing.Point(29, 64);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(72, 119);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 29;
            this.arrow1.TabStop = false;
            // 
            // arrow2
            // 
            this.arrow2.BackColor = System.Drawing.Color.Transparent;
            this.arrow2.Image = global::MemoryGame.Properties.Resources.arrow_up;
            this.arrow2.Location = new System.Drawing.Point(988, 64);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(72, 119);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 29;
            this.arrow2.TabStop = false;
            this.arrow2.Visible = false;
            // 
            // arrow3
            // 
            this.arrow3.BackColor = System.Drawing.Color.Transparent;
            this.arrow3.Image = global::MemoryGame.Properties.Resources.arrow_down;
            this.arrow3.Location = new System.Drawing.Point(31, 452);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(72, 119);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 30;
            this.arrow3.TabStop = false;
            this.arrow3.Visible = false;
            // 
            // arrow4
            // 
            this.arrow4.BackColor = System.Drawing.Color.Transparent;
            this.arrow4.Image = global::MemoryGame.Properties.Resources.arrow_down;
            this.arrow4.Location = new System.Drawing.Point(987, 452);
            this.arrow4.Name = "arrow4";
            this.arrow4.Size = new System.Drawing.Size(72, 119);
            this.arrow4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow4.TabIndex = 30;
            this.arrow4.TabStop = false;
            this.arrow4.Visible = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.arrow4);
            this.Controls.Add(this.arrow3);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.player2txt);
            this.Controls.Add(this.score2txt);
            this.Controls.Add(this.player3txt);
            this.Controls.Add(this.score3txt);
            this.Controls.Add(this.player4txt);
            this.Controls.Add(this.score4txt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player1txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.score1txt);
            this.DoubleBuffered = true;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGame";
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label score1txt;
        private System.Windows.Forms.Timer undorotate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label player1txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label player4txt;
        private System.Windows.Forms.Label score4txt;
        private System.Windows.Forms.Label player3txt;
        private System.Windows.Forms.Label score3txt;
        private System.Windows.Forms.Label player2txt;
        private System.Windows.Forms.Label score2txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox arrow3;
        private System.Windows.Forms.PictureBox arrow4;
    }
}