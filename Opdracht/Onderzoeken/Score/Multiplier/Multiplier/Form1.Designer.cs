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
            this.scorelabel = new System.Windows.Forms.Label();
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
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.scorelabel.Location = new System.Drawing.Point(73, 100);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(80, 24);
            this.scorelabel.TabIndex = 2;
            this.scorelabel.Text = "Score: 0";
            this.scorelabel.Click += new System.EventHandler(this.score_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 158);
            this.Controls.Add(this.scorelabel);
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
        private System.Windows.Forms.Label scorelabel;
    }
}

