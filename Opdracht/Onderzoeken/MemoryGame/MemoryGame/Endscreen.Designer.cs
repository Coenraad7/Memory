namespace MemoryGame
{
    partial class Endscreen
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
            this.button2 = new System.Windows.Forms.Button();
            this.place4 = new System.Windows.Forms.Label();
            this.place3 = new System.Windows.Forms.Label();
            this.place2 = new System.Windows.Forms.Label();
            this.place1 = new System.Windows.Forms.Label();
            this.winlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(12, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button2.Location = new System.Drawing.Point(1032, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Play Again?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // place4
            // 
            this.place4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place4.BackColor = System.Drawing.Color.Transparent;
            this.place4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.place4.ForeColor = System.Drawing.Color.OrangeRed;
            this.place4.Location = new System.Drawing.Point(12, 470);
            this.place4.Name = "place4";
            this.place4.Size = new System.Drawing.Size(1235, 39);
            this.place4.TabIndex = 12;
            this.place4.Text = "4";
            this.place4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.place4.Visible = false;
            // 
            // place3
            // 
            this.place3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place3.BackColor = System.Drawing.Color.Transparent;
            this.place3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.place3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.place3.Location = new System.Drawing.Point(12, 426);
            this.place3.Name = "place3";
            this.place3.Size = new System.Drawing.Size(1235, 46);
            this.place3.TabIndex = 11;
            this.place3.Text = "3";
            this.place3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.place3.Visible = false;
            // 
            // place2
            // 
            this.place2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place2.BackColor = System.Drawing.Color.Transparent;
            this.place2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.place2.ForeColor = System.Drawing.Color.Silver;
            this.place2.Location = new System.Drawing.Point(12, 369);
            this.place2.Name = "place2";
            this.place2.Size = new System.Drawing.Size(1235, 54);
            this.place2.TabIndex = 10;
            this.place2.Text = "2";
            this.place2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.place2.Visible = false;
            // 
            // place1
            // 
            this.place1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.place1.BackColor = System.Drawing.Color.Transparent;
            this.place1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.place1.ForeColor = System.Drawing.Color.Goldenrod;
            this.place1.Location = new System.Drawing.Point(12, 302);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(1235, 71);
            this.place1.TabIndex = 9;
            this.place1.Text = "1";
            this.place1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winlabel
            // 
            this.winlabel.AutoSize = true;
            this.winlabel.BackColor = System.Drawing.Color.Transparent;
            this.winlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.winlabel.ForeColor = System.Drawing.Color.White;
            this.winlabel.Location = new System.Drawing.Point(514, 61);
            this.winlabel.Name = "winlabel";
            this.winlabel.Size = new System.Drawing.Size(235, 54);
            this.winlabel.TabIndex = 8;
            this.winlabel.Text = "You Won!";
            this.winlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Endscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.Memorygame_players;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.place4);
            this.Controls.Add(this.place3);
            this.Controls.Add(this.place2);
            this.Controls.Add(this.place1);
            this.Controls.Add(this.winlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Endscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endscreen";
            this.Load += new System.EventHandler(this.Endscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label place4;
        private System.Windows.Forms.Label place3;
        private System.Windows.Forms.Label place2;
        private System.Windows.Forms.Label place1;
        private System.Windows.Forms.Label winlabel;
    }
}