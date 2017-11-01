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
        public int[] scores = new int[4] { 0, 0, 0, 0 };

        public Endscreen()
        {
            InitializeComponent();
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            List();
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

        private void List()
        {

            //int temp = Math.Max(score1, score2); 

            label2.Text = Variables.playernames[0] + " finished the game with a score of: " + scores[0] + System.Environment.NewLine;

            if (Variables.amountplayers >= 2)
            {
                label2.Text += Variables.playernames[1] + " finished the game with a score of: " + scores[1] + System.Environment.NewLine;
            }
            if (Variables.amountplayers >= 3)
            {
                label2.Text += Variables.playernames[2] + " finished the game with a score of: " + scores[2] + System.Environment.NewLine;
            }
            if (Variables.amountplayers == 4)
            {
                label2.Text += Variables.playernames[3] + " finished the game with a score of: " + scores[3] + System.Environment.NewLine;
            }
        }
    }
}
