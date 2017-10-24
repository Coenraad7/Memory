namespace MemoryGame
{
    partial class Players
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
            this.p3box = new System.Windows.Forms.TextBox();
            this.p4box = new System.Windows.Forms.TextBox();
            this.p2box = new System.Windows.Forms.TextBox();
            this.p1box = new System.Windows.Forms.TextBox();
            this.player4 = new System.Windows.Forms.RadioButton();
            this.player3 = new System.Windows.Forms.RadioButton();
            this.player2 = new System.Windows.Forms.RadioButton();
            this.player1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(1143, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p3box
            // 
            this.p3box.Location = new System.Drawing.Point(132, 75);
            this.p3box.Name = "p3box";
            this.p3box.Size = new System.Drawing.Size(100, 20);
            this.p3box.TabIndex = 17;
            this.p3box.Visible = false;
            this.p3box.TextChanged += new System.EventHandler(this.p3box_TextChanged);
            // 
            // p4box
            // 
            this.p4box.Location = new System.Drawing.Point(132, 101);
            this.p4box.Name = "p4box";
            this.p4box.Size = new System.Drawing.Size(100, 20);
            this.p4box.TabIndex = 18;
            this.p4box.Visible = false;
            this.p4box.TextChanged += new System.EventHandler(this.p4box_TextChanged);
            // 
            // p2box
            // 
            this.p2box.Location = new System.Drawing.Point(132, 49);
            this.p2box.Name = "p2box";
            this.p2box.Size = new System.Drawing.Size(100, 20);
            this.p2box.TabIndex = 16;
            this.p2box.Visible = false;
            this.p2box.TextChanged += new System.EventHandler(this.p2box_TextChanged);
            // 
            // p1box
            // 
            this.p1box.Location = new System.Drawing.Point(132, 23);
            this.p1box.Name = "p1box";
            this.p1box.Size = new System.Drawing.Size(100, 20);
            this.p1box.TabIndex = 15;
            this.p1box.TextChanged += new System.EventHandler(this.p1box_TextChanged);
            // 
            // player4
            // 
            this.player4.AutoSize = true;
            this.player4.Location = new System.Drawing.Point(20, 102);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(68, 17);
            this.player4.TabIndex = 14;
            this.player4.TabStop = true;
            this.player4.Text = "4 Players";
            this.player4.UseVisualStyleBackColor = true;
            this.player4.CheckedChanged += new System.EventHandler(this.player4_CheckedChanged);
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Location = new System.Drawing.Point(20, 76);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(68, 17);
            this.player3.TabIndex = 13;
            this.player3.TabStop = true;
            this.player3.Text = "3 Players";
            this.player3.UseVisualStyleBackColor = true;
            this.player3.CheckedChanged += new System.EventHandler(this.player3_CheckedChanged);
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(20, 53);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(68, 17);
            this.player2.TabIndex = 12;
            this.player2.TabStop = true;
            this.player2.Text = "2 Players";
            this.player2.UseVisualStyleBackColor = true;
            this.player2.CheckedChanged += new System.EventHandler(this.player2_CheckedChanged);
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(20, 24);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(82, 17);
            this.player1.TabIndex = 11;
            this.player1.TabStop = true;
            this.player1.Text = "Singleplayer";
            this.player1.UseVisualStyleBackColor = true;
            this.player1.CheckedChanged += new System.EventHandler(this.player1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button2.Location = new System.Drawing.Point(12, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.p3box);
            this.Controls.Add(this.p4box);
            this.Controls.Add(this.p2box);
            this.Controls.Add(this.p1box);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Players";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Players";
            this.Load += new System.EventHandler(this.Players_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox p3box;
        private System.Windows.Forms.TextBox p4box;
        private System.Windows.Forms.TextBox p2box;
        private System.Windows.Forms.TextBox p1box;
        private System.Windows.Forms.RadioButton player4;
        private System.Windows.Forms.RadioButton player3;
        private System.Windows.Forms.RadioButton player2;
        private System.Windows.Forms.RadioButton player1;
        private System.Windows.Forms.Button button2;
    }
}