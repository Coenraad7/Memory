namespace multiplayer
{
    partial class multiplayer
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
            this.player1 = new System.Windows.Forms.RadioButton();
            this.player2 = new System.Windows.Forms.RadioButton();
            this.player4 = new System.Windows.Forms.RadioButton();
            this.player3 = new System.Windows.Forms.RadioButton();
            this.p1box = new System.Windows.Forms.TextBox();
            this.p2box = new System.Windows.Forms.TextBox();
            this.p3box = new System.Windows.Forms.TextBox();
            this.p4box = new System.Windows.Forms.TextBox();
            this.p1txt = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.p2txt = new System.Windows.Forms.Label();
            this.p3txt = new System.Windows.Forms.Label();
            this.p4txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(29, 14);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(82, 17);
            this.player1.TabIndex = 0;
            this.player1.TabStop = true;
            this.player1.Text = "Singleplayer";
            this.player1.UseVisualStyleBackColor = true;
            this.player1.CheckedChanged += new System.EventHandler(this.player1_CheckedChanged);
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(29, 43);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(68, 17);
            this.player2.TabIndex = 1;
            this.player2.TabStop = true;
            this.player2.Text = "2 Players";
            this.player2.UseVisualStyleBackColor = true;
            this.player2.CheckedChanged += new System.EventHandler(this.player2_CheckedChanged);
            // 
            // player4
            // 
            this.player4.AutoSize = true;
            this.player4.Location = new System.Drawing.Point(29, 92);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(68, 17);
            this.player4.TabIndex = 3;
            this.player4.TabStop = true;
            this.player4.Text = "4 Players";
            this.player4.UseVisualStyleBackColor = true;
            this.player4.CheckedChanged += new System.EventHandler(this.player4_CheckedChanged);
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Location = new System.Drawing.Point(29, 66);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(68, 17);
            this.player3.TabIndex = 2;
            this.player3.TabStop = true;
            this.player3.Text = "3 Players";
            this.player3.UseVisualStyleBackColor = true;
            this.player3.CheckedChanged += new System.EventHandler(this.player3_CheckedChanged);
            // 
            // p1box
            // 
            this.p1box.Location = new System.Drawing.Point(141, 13);
            this.p1box.Name = "p1box";
            this.p1box.Size = new System.Drawing.Size(100, 20);
            this.p1box.TabIndex = 4;
            // 
            // p2box
            // 
            this.p2box.Location = new System.Drawing.Point(141, 39);
            this.p2box.Name = "p2box";
            this.p2box.Size = new System.Drawing.Size(100, 20);
            this.p2box.TabIndex = 5;
            this.p2box.Visible = false;
            // 
            // p3box
            // 
            this.p3box.Location = new System.Drawing.Point(141, 65);
            this.p3box.Name = "p3box";
            this.p3box.Size = new System.Drawing.Size(100, 20);
            this.p3box.TabIndex = 6;
            this.p3box.Visible = false;
            // 
            // p4box
            // 
            this.p4box.Location = new System.Drawing.Point(141, 91);
            this.p4box.Name = "p4box";
            this.p4box.Size = new System.Drawing.Size(100, 20);
            this.p4box.TabIndex = 7;
            this.p4box.Visible = false;
            // 
            // p1txt
            // 
            this.p1txt.AutoSize = true;
            this.p1txt.Location = new System.Drawing.Point(44, 210);
            this.p1txt.Name = "p1txt";
            this.p1txt.Size = new System.Drawing.Size(0, 13);
            this.p1txt.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(141, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // p2txt
            // 
            this.p2txt.AutoSize = true;
            this.p2txt.Location = new System.Drawing.Point(129, 249);
            this.p2txt.Name = "p2txt";
            this.p2txt.Size = new System.Drawing.Size(0, 13);
            this.p2txt.TabIndex = 9;
            // 
            // p3txt
            // 
            this.p3txt.AutoSize = true;
            this.p3txt.Location = new System.Drawing.Point(244, 210);
            this.p3txt.Name = "p3txt";
            this.p3txt.Size = new System.Drawing.Size(0, 13);
            this.p3txt.TabIndex = 9;
            // 
            // p4txt
            // 
            this.p4txt.AutoSize = true;
            this.p4txt.Location = new System.Drawing.Point(370, 249);
            this.p4txt.Name = "p4txt";
            this.p4txt.Size = new System.Drawing.Size(0, 13);
            this.p4txt.TabIndex = 9;
            // 
            // multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 385);
            this.Controls.Add(this.save);
            this.Controls.Add(this.p4txt);
            this.Controls.Add(this.p3txt);
            this.Controls.Add(this.p2txt);
            this.Controls.Add(this.p1txt);
            this.Controls.Add(this.p3box);
            this.Controls.Add(this.p4box);
            this.Controls.Add(this.p2box);
            this.Controls.Add(this.p1box);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "multiplayer";
            this.Text = "Multiplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton player1;
        private System.Windows.Forms.RadioButton player2;
        private System.Windows.Forms.RadioButton player4;
        private System.Windows.Forms.RadioButton player3;
        private System.Windows.Forms.TextBox p1box;
        private System.Windows.Forms.TextBox p2box;
        private System.Windows.Forms.TextBox p3box;
        private System.Windows.Forms.TextBox p4box;
        private System.Windows.Forms.Label p1txt;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label p2txt;
        private System.Windows.Forms.Label p3txt;
        private System.Windows.Forms.Label p4txt;
    }
}

