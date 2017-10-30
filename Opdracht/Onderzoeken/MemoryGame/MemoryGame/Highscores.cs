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
    public partial class Highscores : Form
    {
        public Highscores()
        {
            InitializeComponent();
        }

        private void Highscores_Load(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Very Easy difficulty" + System.Environment.NewLine;
            List(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void dif1_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Very Easy difficulty" + System.Environment.NewLine;
            List(0);
        }

        private void dif2_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Easy difficulty" + System.Environment.NewLine;
            List(1);
        }

        private void dif3_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Normal difficulty" + System.Environment.NewLine;
            List(2);
        }

        private void dif4_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Hard difficulty" + System.Environment.NewLine;
            List(3);
        }

        private void dif5_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Extreme difficulty" + System.Environment.NewLine;
            List(4);
        }

        private void List(int dif)
        {
            for (int i = 0; i < 10; i++)
            {
                Scores.Text += Variables.highscoresplayer[dif, i] + " with a score of: " + Variables.highscoresscore[dif, i] + "!" + System.Environment.NewLine;
            }
        }

        private void Scores_Click(object sender, EventArgs e)
        {

        }
    }
}
