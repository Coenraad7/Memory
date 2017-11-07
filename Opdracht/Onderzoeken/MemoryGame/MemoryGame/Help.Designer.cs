namespace MemoryGame
{
    partial class Help
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(31, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "WHAT IS MEMORY?:",
            "",
            "Memory is a card game in which all of the cards are laid face down on a surface a" +
                "nd two cards are flipped face up over each turn.",
            "The object of the game is to turn over pairs of matching cards. Memory can be pla" +
                "yed with any number of players or as solitaire. ",
            "It is a particularly good game for young children, though adults may find it chal" +
                "lenging and stimulating as well.",
            "The scheme is often used in quiz shows and can be employed as an educational game" +
                ". It requires observation, concentration and a good memory to win.",
            "",
            "Memory is also known as Match Match, Match Up, Concentration, Pelmanism, Shinkei-" +
                "suijaku, Pexeso or simply Pairs.",
            "",
            "WHAT IS THE GOAL?:",
            "",
            "Singleplayer: \tWhen you play by yourself the object of the game is to get as much" +
                " points as possible.",
            "Multiplayer: \tThe object of the game is to collect the most matching pairs.",
            "",
            "HOW TO PLAY?:",
            "",
            "Singleplayer:\tWhen you start the game, you click on 2 random cards. If the 2 card" +
                "s are excactly the same, you will get a point and the cards will disappear. If t" +
                "hey are not, ",
            "\t\tthe cards will flip and you may try again. The game continues in this fashion u" +
                "ntil the board is empty.",
            "\t\tYou can check the highest score in the \"Highscore\"-window. Your",
            "",
            "Multiplayer: \tThe first player chooses a random card. The same player then select" +
                "s another random card. If the two cards are excactly the same they get a point a" +
                "nd choose ",
            "\t\tagain 2 random cards. If the cards are not a match your turn is over and it is " +
                "now the next players turn. The next player chooses their 2 random card. If they " +
                "are ",
            "\t\texcactly the same they get a point and choose again 2 cards. The game continues" +
                " in this fashion until all the cards are played.",
            "",
            "HOW DO I WIN?:",
            "",
            "Once all the cards have been played the player with the most matching pairs is th" +
                "e winner.",
            "",
            "",
            "",
            "",
            "",
            "HINT:",
            "",
            "Singleplayer:\tWhen you get multiple pairs in a row.",
            "Multiplayer: \tJust because it is another players turn doesn\'t mean you should sto" +
                "p paying attention. The cards that other players flip over could be the match yo" +
                "u\'re ",
            "\t\tlooking for. ",
            "\t\tDistract your opponent when it is their turn. When the timer is back to 0 it is" +
                " your turn again."});
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1235, 498);
            this.listBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Help";
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}