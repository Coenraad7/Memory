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
        public Form1()
        {
            InitializeComponent();
        }

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void goed_Click(object sender, EventArgs e)
        {

        }
        private void fout_Click(object sender, EventArgs e)
        {

        }

        public void goed_Click(object sender, EventArgs e)
        {
            double score = 0;
            double multiplier = 1.0;
            if (goed.Click += (s, e) => { multiplier};)
            {
                score *= multiplier;

                switch (multiplier)
                {
                    case 1:
                        multiplier += 1;
                        break;
                    case 2:
                        multiplier += 1;
                        break;
                    case 3:
                        multiplier += 1;
                        break;
                    case 4:
                        multiplier += 1;
                        break;
                    case 5:
                        multiplier += 1;
                        break;
                    case 6:
                        multiplier += 1;
                        break;
                    case 7:
                        multiplier += 1;
                        break;
                    case 8:
                        multiplier += 1;
                        break;
                    case 9:
                        multiplier += 1;
                        break;
                    case 10:
                        multiplier += 1;
                        break;
                    case 11:
                        multiplier += 1;
                        break;
                    case 12:
                        multiplier += 1;
                        break;
                    case 13:
                        multiplier += 1;
                        break;
                    case 14:
                        multiplier += 1;
                        break;
                    case 15:
                        multiplier += 1;
                        break;
                    case 16:
                        multiplier += 1;
                        break;
                    case 17:
                        multiplier += 1;
                        break;
                    case 18:
                        multiplier += 1;
                        break;
                    default:
                        multiplier = 1;
                        break;
                }
                else if (fout.Click = true)
                {
                    multiplier -= 0.1;
                }
                
            }
        }
    }
}