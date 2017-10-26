namespace Multiplier
{
    partial class Form1
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
            this.goed = new System.Windows.Forms.Button();
            this.fout = new System.Windows.Forms.Button();
            this.score1txt = new System.Windows.Forms.Label();
            this.score2txt = new System.Windows.Forms.Label();
            this.score3txt = new System.Windows.Forms.Label();
            this.score4txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goed
            // 
            this.goed.Location = new System.Drawing.Point(23, 41);
            this.goed.Name = "goed";
            this.goed.Size = new System.Drawing.Size(75, 23);
            this.goed.TabIndex = 0;
            this.goed.Text = "goed";
            this.goed.UseVisualStyleBackColor = true;
            this.goed.Click += new System.EventHandler(this.goed_Click);
            // 
            // fout
            // 
            this.fout.Location = new System.Drawing.Point(121, 41);
            this.fout.Name = "fout";
            this.fout.Size = new System.Drawing.Size(75, 23);
            this.fout.TabIndex = 1;
            this.fout.Text = "Fout";
            this.fout.UseVisualStyleBackColor = true;
            this.fout.Click += new System.EventHandler(this.fout_Click);
            // 
            // score1txt
            // 
            this.score1txt.AutoSize = true;
            this.score1txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.score1txt.Location = new System.Drawing.Point(19, 111);
            this.score1txt.Name = "score1txt";
            this.score1txt.Size = new System.Drawing.Size(95, 24);
            this.score1txt.TabIndex = 2;
            this.score1txt.Text = "Score 1: 0";
            // 
            // score2txt
            // 
            this.score2txt.AutoSize = true;
            this.score2txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.score2txt.Location = new System.Drawing.Point(134, 111);
            this.score2txt.Name = "score2txt";
            this.score2txt.Size = new System.Drawing.Size(95, 24);
            this.score2txt.TabIndex = 2;
            this.score2txt.Text = "Score 2: 0";
            // 
            // score3txt
            // 
            this.score3txt.AutoSize = true;
            this.score3txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.score3txt.Location = new System.Drawing.Point(264, 111);
            this.score3txt.Name = "score3txt";
            this.score3txt.Size = new System.Drawing.Size(95, 24);
            this.score3txt.TabIndex = 2;
            this.score3txt.Text = "Score 3: 0";
            // 
            // score4txt
            // 
            this.score4txt.AutoSize = true;
            this.score4txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.score4txt.Location = new System.Drawing.Point(379, 111);
            this.score4txt.Name = "score4txt";
            this.score4txt.Size = new System.Drawing.Size(95, 24);
            this.score4txt.TabIndex = 2;
            this.score4txt.Text = "Score 4: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 158);
            this.Controls.Add(this.score4txt);
            this.Controls.Add(this.score3txt);
            this.Controls.Add(this.score2txt);
            this.Controls.Add(this.score1txt);
            this.Controls.Add(this.fout);
            this.Controls.Add(this.goed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goed;
        private System.Windows.Forms.Button fout;
        private System.Windows.Forms.Label score1txt;
        private System.Windows.Forms.Label score2txt;
        private System.Windows.Forms.Label score3txt;
        private System.Windows.Forms.Label score4txt;
    }
}

