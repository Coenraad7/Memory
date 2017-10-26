namespace MemoryGame
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
            this.SuspendLayout();
            // 
            // score1txt
            // 
            this.score1txt.AutoSize = true;
            this.score1txt.Location = new System.Drawing.Point(1042, 37);
            this.score1txt.Name = "score1txt";
            this.score1txt.Size = new System.Drawing.Size(47, 13);
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
            this.reset.Location = new System.Drawing.Point(1045, 205);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 17;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(1045, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player1txt
            // 
            this.player1txt.AutoSize = true;
            this.player1txt.Location = new System.Drawing.Point(1041, 24);
            this.player1txt.Name = "player1txt";
            this.player1txt.Size = new System.Drawing.Size(79, 13);
            this.player1txt.TabIndex = 19;
            this.player1txt.Text = "Name Player 1:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 21);
            this.panel1.TabIndex = 20;
            // 
            // player4txt
            // 
            this.player4txt.AutoSize = true;
            this.player4txt.Location = new System.Drawing.Point(1041, 144);
            this.player4txt.Name = "player4txt";
            this.player4txt.Size = new System.Drawing.Size(79, 13);
            this.player4txt.TabIndex = 22;
            this.player4txt.Text = "Name Player 4:";
            // 
            // score4txt
            // 
            this.score4txt.AutoSize = true;
            this.score4txt.Location = new System.Drawing.Point(1042, 157);
            this.score4txt.Name = "score4txt";
            this.score4txt.Size = new System.Drawing.Size(47, 13);
            this.score4txt.TabIndex = 21;
            this.score4txt.Text = "Score: 0";
            // 
            // player3txt
            // 
            this.player3txt.AutoSize = true;
            this.player3txt.Location = new System.Drawing.Point(1041, 104);
            this.player3txt.Name = "player3txt";
            this.player3txt.Size = new System.Drawing.Size(79, 13);
            this.player3txt.TabIndex = 24;
            this.player3txt.Text = "Name Player 3:";
            // 
            // score3txt
            // 
            this.score3txt.AutoSize = true;
            this.score3txt.Location = new System.Drawing.Point(1042, 117);
            this.score3txt.Name = "score3txt";
            this.score3txt.Size = new System.Drawing.Size(47, 13);
            this.score3txt.TabIndex = 23;
            this.score3txt.Text = "Score: 0";
            // 
            // player2txt
            // 
            this.player2txt.AutoSize = true;
            this.player2txt.Location = new System.Drawing.Point(1041, 64);
            this.player2txt.Name = "player2txt";
            this.player2txt.Size = new System.Drawing.Size(79, 13);
            this.player2txt.TabIndex = 26;
            this.player2txt.Text = "Name Player 2:";
            // 
            // score2txt
            // 
            this.score2txt.AutoSize = true;
            this.score2txt.Location = new System.Drawing.Point(1042, 77);
            this.score2txt.Name = "score2txt";
            this.score2txt.Size = new System.Drawing.Size(47, 13);
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
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(1062, 277);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(0, 26);
            this.txtresult.TabIndex = 27;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 676);
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
    }
}