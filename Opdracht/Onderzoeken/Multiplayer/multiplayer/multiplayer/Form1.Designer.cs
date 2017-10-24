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
            this.dif1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dif5 = new System.Windows.Forms.RadioButton();
            this.dif4 = new System.Windows.Forms.RadioButton();
            this.dif3 = new System.Windows.Forms.RadioButton();
            this.dif2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.theme5 = new System.Windows.Forms.RadioButton();
            this.theme4 = new System.Windows.Forms.RadioButton();
            this.theme3 = new System.Windows.Forms.RadioButton();
            this.theme2 = new System.Windows.Forms.RadioButton();
            this.theme1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(28, 19);
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
            this.player2.Location = new System.Drawing.Point(28, 44);
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
            this.player4.Location = new System.Drawing.Point(28, 96);
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
            this.player3.Location = new System.Drawing.Point(28, 70);
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
            this.p1box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.p1box.Location = new System.Drawing.Point(143, 18);
            this.p1box.Name = "p1box";
            this.p1box.Size = new System.Drawing.Size(100, 20);
            this.p1box.TabIndex = 4;
            this.p1box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p1box_KeyPress);
            // 
            // p2box
            // 
            this.p2box.Location = new System.Drawing.Point(143, 43);
            this.p2box.Name = "p2box";
            this.p2box.Size = new System.Drawing.Size(100, 20);
            this.p2box.TabIndex = 5;
            this.p2box.Visible = false;
            this.p2box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p2box_KeyPress);
            // 
            // p3box
            // 
            this.p3box.Location = new System.Drawing.Point(143, 69);
            this.p3box.Name = "p3box";
            this.p3box.Size = new System.Drawing.Size(100, 20);
            this.p3box.TabIndex = 6;
            this.p3box.Visible = false;
            this.p3box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p3box_KeyPress);
            // 
            // p4box
            // 
            this.p4box.Location = new System.Drawing.Point(143, 95);
            this.p4box.Name = "p4box";
            this.p4box.Size = new System.Drawing.Size(100, 20);
            this.p4box.TabIndex = 7;
            this.p4box.Visible = false;
            this.p4box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.p4box_KeyPress);
            // 
            // p1txt
            // 
            this.p1txt.AutoSize = true;
            this.p1txt.Location = new System.Drawing.Point(443, 12);
            this.p1txt.Name = "p1txt";
            this.p1txt.Size = new System.Drawing.Size(13, 13);
            this.p1txt.TabIndex = 9;
            this.p1txt.Text = "1";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(28, 354);
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
            this.p2txt.Location = new System.Drawing.Point(443, 33);
            this.p2txt.Name = "p2txt";
            this.p2txt.Size = new System.Drawing.Size(13, 13);
            this.p2txt.TabIndex = 9;
            this.p2txt.Text = "2";
            // 
            // p3txt
            // 
            this.p3txt.AutoSize = true;
            this.p3txt.Location = new System.Drawing.Point(443, 56);
            this.p3txt.Name = "p3txt";
            this.p3txt.Size = new System.Drawing.Size(13, 13);
            this.p3txt.TabIndex = 9;
            this.p3txt.Text = "3";
            // 
            // p4txt
            // 
            this.p4txt.AutoSize = true;
            this.p4txt.Location = new System.Drawing.Point(443, 82);
            this.p4txt.Name = "p4txt";
            this.p4txt.Size = new System.Drawing.Size(13, 13);
            this.p4txt.TabIndex = 9;
            this.p4txt.Text = "4";
            // 
            // dif1
            // 
            this.dif1.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif1.AutoSize = true;
            this.dif1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dif1.Location = new System.Drawing.Point(16, 22);
            this.dif1.Name = "dif1";
            this.dif1.Size = new System.Drawing.Size(64, 23);
            this.dif1.TabIndex = 11;
            this.dif1.TabStop = true;
            this.dif1.Text = "Very Easy";
            this.dif1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dif5);
            this.panel1.Controls.Add(this.dif4);
            this.panel1.Controls.Add(this.dif3);
            this.panel1.Controls.Add(this.dif2);
            this.panel1.Controls.Add(this.dif1);
            this.panel1.Location = new System.Drawing.Point(12, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 61);
            this.panel1.TabIndex = 12;
            // 
            // dif5
            // 
            this.dif5.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif5.AutoSize = true;
            this.dif5.Cursor = System.Windows.Forms.Cursors.Default;
            this.dif5.Location = new System.Drawing.Point(234, 22);
            this.dif5.Name = "dif5";
            this.dif5.Size = new System.Drawing.Size(55, 23);
            this.dif5.TabIndex = 15;
            this.dif5.TabStop = true;
            this.dif5.Text = "Extreme";
            this.dif5.UseVisualStyleBackColor = true;
            // 
            // dif4
            // 
            this.dif4.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif4.AutoSize = true;
            this.dif4.Cursor = System.Windows.Forms.Cursors.Default;
            this.dif4.Location = new System.Drawing.Point(188, 22);
            this.dif4.Name = "dif4";
            this.dif4.Size = new System.Drawing.Size(40, 23);
            this.dif4.TabIndex = 14;
            this.dif4.TabStop = true;
            this.dif4.Text = "Hard";
            this.dif4.UseVisualStyleBackColor = true;
            // 
            // dif3
            // 
            this.dif3.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif3.AutoSize = true;
            this.dif3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dif3.Location = new System.Drawing.Point(132, 22);
            this.dif3.Name = "dif3";
            this.dif3.Size = new System.Drawing.Size(50, 23);
            this.dif3.TabIndex = 13;
            this.dif3.TabStop = true;
            this.dif3.Text = "Normal";
            this.dif3.UseVisualStyleBackColor = true;
            // 
            // dif2
            // 
            this.dif2.Appearance = System.Windows.Forms.Appearance.Button;
            this.dif2.AutoSize = true;
            this.dif2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dif2.Location = new System.Drawing.Point(86, 22);
            this.dif2.Name = "dif2";
            this.dif2.Size = new System.Drawing.Size(40, 23);
            this.dif2.TabIndex = 12;
            this.dif2.TabStop = true;
            this.dif2.Text = "Easy";
            this.dif2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.player1);
            this.panel2.Controls.Add(this.p2box);
            this.panel2.Controls.Add(this.player2);
            this.panel2.Controls.Add(this.player3);
            this.panel2.Controls.Add(this.p1box);
            this.panel2.Controls.Add(this.p4box);
            this.panel2.Controls.Add(this.player4);
            this.panel2.Controls.Add(this.p3box);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 136);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.theme5);
            this.panel3.Controls.Add(this.theme4);
            this.panel3.Controls.Add(this.theme3);
            this.panel3.Controls.Add(this.theme2);
            this.panel3.Controls.Add(this.theme1);
            this.panel3.Location = new System.Drawing.Point(12, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 127);
            this.panel3.TabIndex = 14;
            // 
            // theme5
            // 
            this.theme5.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme5.AutoSize = true;
            this.theme5.Cursor = System.Windows.Forms.Cursors.Default;
            this.theme5.Location = new System.Drawing.Point(234, 90);
            this.theme5.Name = "theme5";
            this.theme5.Size = new System.Drawing.Size(23, 23);
            this.theme5.TabIndex = 15;
            this.theme5.TabStop = true;
            this.theme5.Text = "5";
            this.theme5.UseVisualStyleBackColor = true;
            // 
            // theme4
            // 
            this.theme4.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme4.AutoSize = true;
            this.theme4.Cursor = System.Windows.Forms.Cursors.Default;
            this.theme4.Location = new System.Drawing.Point(188, 90);
            this.theme4.Name = "theme4";
            this.theme4.Size = new System.Drawing.Size(23, 23);
            this.theme4.TabIndex = 14;
            this.theme4.TabStop = true;
            this.theme4.Text = "4";
            this.theme4.UseVisualStyleBackColor = true;
            // 
            // theme3
            // 
            this.theme3.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme3.AutoSize = true;
            this.theme3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.theme3.Location = new System.Drawing.Point(132, 90);
            this.theme3.Name = "theme3";
            this.theme3.Size = new System.Drawing.Size(23, 23);
            this.theme3.TabIndex = 13;
            this.theme3.TabStop = true;
            this.theme3.Text = "3";
            this.theme3.UseVisualStyleBackColor = true;
            // 
            // theme2
            // 
            this.theme2.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme2.AutoSize = true;
            this.theme2.Cursor = System.Windows.Forms.Cursors.Default;
            this.theme2.Location = new System.Drawing.Point(73, 90);
            this.theme2.Name = "theme2";
            this.theme2.Size = new System.Drawing.Size(23, 23);
            this.theme2.TabIndex = 12;
            this.theme2.TabStop = true;
            this.theme2.Text = "2";
            this.theme2.UseVisualStyleBackColor = true;
            // 
            // theme1
            // 
            this.theme1.Appearance = System.Windows.Forms.Appearance.Button;
            this.theme1.AutoSize = true;
            this.theme1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.theme1.Location = new System.Drawing.Point(16, 90);
            this.theme1.Name = "theme1";
            this.theme1.Size = new System.Drawing.Size(23, 23);
            this.theme1.TabIndex = 11;
            this.theme1.TabStop = true;
            this.theme1.Text = "1";
            this.theme1.UseVisualStyleBackColor = true;
            // 
            // multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p2txt);
            this.Controls.Add(this.save);
            this.Controls.Add(this.p1txt);
            this.Controls.Add(this.p3txt);
            this.Controls.Add(this.p4txt);
            this.Name = "multiplayer";
            this.Text = "Multiplayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton player1;
        private System.Windows.Forms.RadioButton player2;
        private System.Windows.Forms.RadioButton player4;
        private System.Windows.Forms.RadioButton player3;
        private System.Windows.Forms.TextBox p2box;
        private System.Windows.Forms.TextBox p3box;
        private System.Windows.Forms.TextBox p4box;
        private System.Windows.Forms.Label p1txt;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label p2txt;
        private System.Windows.Forms.Label p3txt;
        private System.Windows.Forms.Label p4txt;
        private System.Windows.Forms.TextBox p1box;
        private System.Windows.Forms.RadioButton dif1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton dif2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton dif5;
        private System.Windows.Forms.RadioButton dif4;
        private System.Windows.Forms.RadioButton dif3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton theme5;
        private System.Windows.Forms.RadioButton theme4;
        private System.Windows.Forms.RadioButton theme3;
        private System.Windows.Forms.RadioButton theme2;
        private System.Windows.Forms.RadioButton theme1;
    }
}

