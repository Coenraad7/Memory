using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorygame
{
    public partial class GameWindow : Form
    {
        // variables 
        int score = 0; // score system
        Random location = new Random(); // Selecteerd random plek voor de kaarten.
        List<int> x = new List<int>();  // x voor elke picture box.
        List<int> y = new List<int>();  // y voor elke picture box.

        bool again = false; // play again.


        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            Card1.Image = Properties.Resources._1;
            DubCard1.Image = Properties.Resources._1;
            Card2.Image = Properties.Resources._2;
            DubCard2.Image = Properties.Resources._2;
            Card3.Image = Properties.Resources._3;
            DubCard3.Image = Properties.Resources._3;
            Card4.Image = Properties.Resources._4;
            DubCard4.Image = Properties.Resources._4;
            Card5.Image = Properties.Resources._5;
            DubCard5.Image = Properties.Resources._5;
            Card6.Image = Properties.Resources._6;
            DubCard6.Image = Properties.Resources._6;
            Card7.Image = Properties.Resources._7;
            DubCard7.Image = Properties.Resources._7;
            Card8.Image = Properties.Resources._8;
            DubCard8.Image = Properties.Resources._8;
            Card9.Image = Properties.Resources._9;
            DubCard9.Image = Properties.Resources._9;
            Card10.Image = Properties.Resources._10;
            DubCard10.Image = Properties.Resources._10;
            Card11.Image = Properties.Resources._11;
            DubCard11.Image = Properties.Resources._11;
            Card12.Image = Properties.Resources._12;
            DubCard12.Image = Properties.Resources._12;
            Card13.Image = Properties.Resources._13;
            DubCard13.Image = Properties.Resources._13;
            Card14.Image = Properties.Resources._14;
            DubCard14.Image = Properties.Resources._14;
            Card15.Image = Properties.Resources._15;
            DubCard15.Image = Properties.Resources._15;
            Card16.Image = Properties.Resources._16;
            DubCard16.Image = Properties.Resources._16;
            Card17.Image = Properties.Resources._17;
            DubCard17.Image = Properties.Resources._17;
            Card18.Image = Properties.Resources._18;
            DubCard18.Image = Properties.Resources._18;


            private void timer1_Tick(object sender, EventArgs e)
            {
                timer1.Stop();
                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    picture.Image = Properties.Resources.Background;

                }
            }

            private void timer2_Tick(object sender, EventArgs e)
            {
                int timer = Convert.ToInt32(label1.Text);
                timer = timer - 1;
                label1.Text = Convert.ToString(timer);
                if (timer == 0)
                {
                    timer2.Stop();
                }
            }

            private void Card1_Click(object sender, EventArgs e)
            {
                Card1.Image = Properties.Resources._1;
            }

            private void DubCard1_Click(object sender, EventArgs e)
            {
                DubCard1.Image = Properties.Resources._1;
            }

            private void Card2_Click(object sender, EventArgs e)
            {
                Card2.Image = Properties.Resources._2;
            }

            private void DubCard2_Click(object sender, EventArgs e)
            {
                DubCard2.Image = Properties.Resources._2;
            }

            private void Card3_Click(object sender, EventArgs e)
            {
                Card3.Image = Properties.Resources._3;
            }

            private void DubCard3_Click(object sender, EventArgs e)
            {
                DubCard3.Image = Properties.Resources._3;
            }

            private void Card4_Click(object sender, EventArgs e)
            {
                Card4.Image = Properties.Resources._4;
            }

            private void DubCard4_Click(object sender, EventArgs e)
            {
                DubCard4.Image = Properties.Resources._4;
            }

            private void Card5_Click(object sender, EventArgs e)
            {
                Card5.Image = Properties.Resources._5;
            }

            private void DubCard5_Click(object sender, EventArgs e)
            {
                DubCard5.Image = Properties.Resources._5;
            }

            private void Card6_Click(object sender, EventArgs e)
            {
                Card6.Image = Properties.Resources._6
            }

            private void DubCard6_Click(object sender, EventArgs e)
            {
                DubCard6.Image = Properties.Resources._6;
            }

            private void Card7_Click(object sender, EventArgs e)
            {
                Card7.Image = Properties.Resources._7;
            }

            private void DubCard7_Click(object sender, EventArgs e)
            {
                DubCard7.Image = Properties.Resources._7;
            }

            private void Card8_Click(object sender, EventArgs e)
            {
                Card8.Image = Properties.Resources._8;
            }

            private void DubCard8_Click(object sender, EventArgs e)
            {
                DubCard8.Image = Properties.Resources._8;
            }

            private void Card9_Click(object sender, EventArgs e)
            {
                Card9.Image = Properties.Resources._9;
            }

            private void DubCard9_Click(object sender, EventArgs e)
            {
                DubCard9.Image = Properties.Resources._9;
            }

            private void Card10_Click(object sender, EventArgs e)
            {
                Card10.Image = Properties.Resources._10;
            }

            private void DubCard10_Click(object sender, EventArgs e)
            {
                DubCard10.Image = Properties.Resources._10;
            }

            private void Card11_Click(object sender, EventArgs e)
            {
                Card11.Image = Properties.Resources._11;
            }

            private void DubCard11_Click(object sender, EventArgs e)
            {
                DubCard11.Image = Properties.Resources._11;
            }

            private void Card12_Click(object sender, EventArgs e)
            {
                Card12.Image = Properties.Resources._12;
            }

            private void DubCard12_Click(object sender, EventArgs e)
            {
                DubCard12.Image = Properties.Resources._12;
            }

            private void Card13_Click(object sender, EventArgs e)
            {
                Card13.Image = Properties.Resources._13;
            }

            private void DubCard13_Click(object sender, EventArgs e)
            {
                DubCard13.Image = Properties.Resources._13;
            }

            private void Card14_Click(object sender, EventArgs e)
            {
                Card14.Image = Properties.Resources._14;
            }

            private void DubCard14_Click(object sender, EventArgs e)
            {
                DubCard14.Image = Properties.Resources._14;
            }

            private void Card15_Click(object sender, EventArgs e)
            {
                Card15.Image = Properties.Resources._15;
            }

            private void DubCard15_Click(object sender, EventArgs e)
            {
                DubCard15.Image = Properties.Resources._15;
            }

            private void Card16_Click(object sender, EventArgs e)
            {
                Card16.Image = Properties.Resources._16;
            }

            private void DubCard16_Click(object sender, EventArgs e)
            {
                DubCard16.Image = Properties.Resources._16;
            }

            private void Card17_Click(object sender, EventArgs e)
            {
                Card17.Image = Properties.Resources._17;
            }

            private void DubCard17_Click(object sender, EventArgs e)
            {
                DubCard17.Image = Properties.Resources._17;
            }

            private void Card18_Click(object sender, EventArgs e)
            {
                Card18.Image = Properties.Resources._18;
            }

            private void DubCard18_Click(object sender, EventArgs e)
            {
                DubCard18.Image = Properties.Resources._18;
            }
        }

        
    }
}
