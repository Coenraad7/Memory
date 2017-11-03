namespace MemoryGame
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.button1 = new System.Windows.Forms.Button();
            this.Flash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.Flash1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(31, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Flash1
            // 
            this.Flash1.Enabled = true;
            this.Flash1.Location = new System.Drawing.Point(-32, -35);
            this.Flash1.Name = "Flash1";
            this.Flash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Flash1.OcxState")));
            this.Flash1.Size = new System.Drawing.Size(1291, 719);
            this.Flash1.TabIndex = 21;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Flash1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Flash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private AxShockwaveFlashObjects.AxShockwaveFlash Flash1;
    }
}