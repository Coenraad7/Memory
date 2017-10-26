using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplier
{

    public partial class Form1 : Form
    {
        int winst = 1, score1 = 0, score2 = 0, score3 = 0, score4 = 0, turn = 1;
        private void multiplayer (bool correct)
        {
            if (correct == true)
            {
                if (turn == 1)
                {
                    score1 += Convert.ToInt32(winst);
                }
                else if (turn == 2)
                {
                    score2 += Convert.ToInt32(winst);
                }
                else if (turn == 3)
                {
                    score3 += Convert.ToInt32(winst);
                }
                else if (turn == 4)
                {
                    score4 += Convert.ToInt32(winst);
                }

            }
            else if (correct == false)
            {
                if (turn != 4)
                {
                    turn += 1;
                }
                else if (turn == 4)
                {
                    turn -= 3;
                }
            }
            score1txt.Text = "Score1: " + Convert.ToString(score1);
            score2txt.Text = "Score2: " + Convert.ToString(score2);
            score3txt.Text = "Score3: " + Convert.ToString(score3);
            score4txt.Text = "Score4: " + Convert.ToString(score4);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void goed_Click(object sender, EventArgs e)
        {
            multiplayer(true);
        }

        private void fout_Click(object sender, EventArgs e)
        {
            multiplayer(false);
        }
    }
}