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
            this.label1 = new System.Windows.Forms.Label();
            this.undorotate = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.player1txt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1041, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Score: 0";
            // 
            // undorotate
            // 
            this.undorotate.Interval = 400;
            this.undorotate.Tick += new System.EventHandler(this.undorotate_Tick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(1045, 106);
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
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player1txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer undorotate;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label player1txt;
        private System.Windows.Forms.Panel panel1;
    }
}