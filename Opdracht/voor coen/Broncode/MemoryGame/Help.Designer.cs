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
            this.Singleplayerbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.singlebut = new System.Windows.Forms.Button();
            this.multibut = new System.Windows.Forms.Button();
            this.Multiplayerbox = new System.Windows.Forms.ListBox();
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
            // Singleplayerbox
            // 
            this.Singleplayerbox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.Singleplayerbox.FormattingEnabled = true;
            this.Singleplayerbox.ItemHeight = 21;
            this.Singleplayerbox.Items.AddRange(new object[] {
            "WHAT IS MEMORY?:",
            "",
            "Memory is a card game in which all of the cards are faced down on a surface and t" +
                "wo cards are flipped face up over each turn.",
            "The object of the game is to turn over pairs of matching cards. Memory can be pla" +
                "yed with any number of players or as solitaire. ",
            "It is a particularly good game for young children, though adults may find it chal" +
                "lenging and stimulating as well.",
            "A memory game requires observation, concentration and a good memory to win.",
            "",
            "Memory is also known as Match Match, Match Up, Concentration, Pelmanism, Shinkei-" +
                "suijaku, Pexeso or simply Pairs.",
            "",
            "WHAT IS THE GOAL?:",
            "",
            "The objective of the game is to get as much points as possible.",
            "",
            "HOW TO PLAY?:",
            "",
            "When you start the game, you click on two random cards. If the two cards are the " +
                "same, you will get a point and the cards will disappear. If they are not, ",
            "The cards will flip and you may try again. The game continues in this fashion unt" +
                "il the board is empty.",
            "",
            "SCORE:",
            "",
            "By default you 10 points per correct pair but when you will receive -1 point for " +
                "each wrong selected pair. This will be subtracted from the default points.",
            "When you get multiple pairs in a row, you get a combo. This will activate a multi" +
                "plier to your points. This means you will receive more points at once. ",
            "A wrong pair turns the Multiplier off.",
            "While playing you can see your score in the top right corner. When you finish you" +
                "r game, your score will be saved in the high score window. ",
            "You can check if you have best score. ",
            "",
            "HINT:",
            "When you know where one pair is do not open them yet, search further until you kn" +
                "ow a few other pairs are as well. By doing this you will get more points."});
            this.Singleplayerbox.Location = new System.Drawing.Point(12, 72);
            this.Singleplayerbox.Name = "Singleplayerbox";
            this.Singleplayerbox.Size = new System.Drawing.Size(1235, 487);
            this.Singleplayerbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "Help";
            // 
            // singlebut
            // 
            this.singlebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.singlebut.Location = new System.Drawing.Point(1107, 576);
            this.singlebut.Name = "singlebut";
            this.singlebut.Size = new System.Drawing.Size(140, 34);
            this.singlebut.TabIndex = 22;
            this.singlebut.Text = "Singleplayer";
            this.singlebut.UseVisualStyleBackColor = true;
            this.singlebut.Click += new System.EventHandler(this.singlebut_Click);
            // 
            // multibut
            // 
            this.multibut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.multibut.Location = new System.Drawing.Point(1107, 613);
            this.multibut.Name = "multibut";
            this.multibut.Size = new System.Drawing.Size(140, 34);
            this.multibut.TabIndex = 24;
            this.multibut.Text = "Multiplayer";
            this.multibut.UseVisualStyleBackColor = true;
            this.multibut.Click += new System.EventHandler(this.multibut_Click);
            // 
            // Multiplayerbox
            // 
            this.Multiplayerbox.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.Multiplayerbox.FormattingEnabled = true;
            this.Multiplayerbox.ItemHeight = 21;
            this.Multiplayerbox.Items.AddRange(new object[] {
            "WHAT IS MEMORY?:",
            "",
            "Memory is a card game in which all of the cards are faced down on a surface and t" +
                "wo cards are flipped face up over each turn.",
            "The object of the game is to turn over pairs of matching cards. Memory can be pla" +
                "yed with any number of players or as solitaire. ",
            "It is a particularly good game for young children, though adults may find it chal" +
                "lenging and stimulating as well.",
            "A memory game requires observation, concentration and a good memory to win.",
            "",
            "Memory is also known as Match Match, Match Up, Concentration, Pelmanism, Shinkei-" +
                "suijaku, Pexeso or simply Pairs.",
            "",
            "WHAT IS THE GOAL?:",
            "",
            "The object of the game is to collect the most matched pairs.",
            "",
            "HOW TO PLAY?:",
            "",
            "When you start the game, the first player clicks on two random cards. If the card" +
                "s are not a match your turn is over",
            "and it is now the next players turn. The next player chooses their two random car" +
                "ds. If the two cards are the same, you will get a point and ",
            "the cards will disappear. If they are not, the cards will flip and you may try ag" +
                "ain. The game continues in this fashion until the board is empty.",
            "",
            "HOW DO I WIN?:",
            "",
            "For every correct pair you get a point. The one with most points at the end wins." +
                " ",
            "",
            "HINT:",
            "",
            "Just because it is another players turn doesn\'t mean you should stop paying atten" +
                "tion. The cards that other players flip over could be the match you\'re ",
            "looking for.",
            "Distract your opponent when it is their turn. When the timer is zero it is your t" +
                "urn again."});
            this.Multiplayerbox.Location = new System.Drawing.Point(12, 72);
            this.Multiplayerbox.Name = "Multiplayerbox";
            this.Multiplayerbox.Size = new System.Drawing.Size(1235, 487);
            this.Multiplayerbox.TabIndex = 25;
            this.Multiplayerbox.Visible = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.Memorygame_players;
            this.ClientSize = new System.Drawing.Size(1259, 676);
            this.Controls.Add(this.multibut);
            this.Controls.Add(this.singlebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Singleplayerbox);
            this.Controls.Add(this.Multiplayerbox);
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
        private System.Windows.Forms.ListBox Singleplayerbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button singlebut;
        private System.Windows.Forms.Button multibut;
        private System.Windows.Forms.ListBox Multiplayerbox;
    }
}