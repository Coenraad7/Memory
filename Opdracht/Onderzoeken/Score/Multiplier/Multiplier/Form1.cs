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
        int score = 0;
        double winst = 10;
        double multiplier = 1;

        private void test (bool iets)
        {
            if (iets == true)
            {
                score += Convert.ToInt32(multiplier * winst);

                if (multiplier % 1 == 0)
                {
                    multiplier++;
                }
                else
                {
                    multiplier = 1;
                }
            }
            else if (iets == false)
            {
                if (multiplier <= 1)
                {
                    multiplier -= 0.1;
                }
                else
                {
                    multiplier = 1;
                }
            }
            scorelabel.Text = "Score: " + Convert.ToString(score);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void goed_Click(object sender, EventArgs e)
        {
            test(true);
        }

        private void fout_Click(object sender, EventArgs e)
        {
            test(false);
        }
    }
}