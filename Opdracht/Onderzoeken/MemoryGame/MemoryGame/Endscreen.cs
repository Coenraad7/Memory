using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Endscreen : Form
    {
        public int score1;
        public int score2;
        public int score3;
        public int score4;
        int Max; // word niet gebruikt?

        public Endscreen()
        {
            InitializeComponent();
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            List();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.MdiParent = this.ParentForm;
            Highscores.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void List()
        {

            int temp = Math.Max(score1, score2); 

            label2.Text = Variables.playernames[0] + " finished the game with a score of: " + score1 + System.Environment.NewLine;

            if (Variables.amountplayers >= 2)
            {
                label2.Text += Variables.playernames[1] + " finished the game with a score of: " + score2 + System.Environment.NewLine;
            }
            if (Variables.amountplayers >= 3)
            {
                label2.Text += Variables.playernames[2] + " finished the game with a score of: " + score3 + System.Environment.NewLine;
            }
            if (Variables.amountplayers == 4)
            {
                label2.Text += Variables.playernames[3] + " finished the game with a score of: " + score4 + System.Environment.NewLine;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
