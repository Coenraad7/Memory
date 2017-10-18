using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_en_paren
{
    public partial class Form1 : Form
    {
        int[,] cardproperties = new int[36, 2];
        int count,card1,card2,oldcard = -1,oldcard2 = -1;
        PictureBox cardinfo1,cardinfo2;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            scramble();
        }

        private void scramble()
        {
            Random rng = new Random();
            bool done = false, check = false;
            int random = 0;

            for (int i = 0; i < 16; i++)
            {
                done = false;
                check = false;

                while (done == false)
                {
                    check = true;
                    done = true;
                    random = rng.Next(1, 9);
                    for (int e = 0; e < 16; e++)
                    {
                        
                        if ((cardproperties[e, 1] == random) && (check == false))
                        {
                            done = false;
                        }
                        else if ((cardproperties[e, 1] == random) && (check == true))
                        {
                            check = false;
                        }
                    }                   
                }
                cardproperties[i, 1] = random;
                //label1.Text += Convert.ToString(cardproperties[i, 1]) + ",";
            }
        }

        private void rotate(object sender, int picture)
        {
            PictureBox card = (PictureBox)sender;
            card.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + cardproperties[picture,1]);
            //label1.Text = Convert.ToString (cardproperties[picture, 1]);

            if (card1 == 0)
            {
                card1 = cardproperties[picture, 1];
                cardinfo1 = card;
                oldcard = picture;
            }
            else if (card2 == 0 && oldcard != picture)
            {
                //label1.Text = oldcard + "," + picture;
                card2 = cardproperties[picture, 1];
                cardinfo2 = card;
                oldcard2 = picture;
                paircheck();
            }
            else if (card2 != 0 && oldcard != picture && oldcard2 != picture)
            {
                //label1.Text = oldcard + "," + picture;
                cardinfo1.BackgroundImage = Properties.Resources._default;
                cardinfo2.BackgroundImage = Properties.Resources._default;
                card1 = cardproperties[picture, 1];
                cardinfo1 = card;
                oldcard = picture;
                card2 = 0;
                cardinfo2 = null;
            }
        }

        private void paircheck()
        {
            //label1.Text = card1 + "," + card2;
            if (card1 == card2)
            {
                cardinfo1.BackgroundImage = Properties.Resources._default;
                cardinfo2.BackgroundImage = Properties.Resources._default;
                cardinfo1.Visible = false;
                cardinfo2.Visible = false;
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
            }
        }

        private void Reset()
        {
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                //int imageIndex = (int)pictureBox.Tag;
                pictureBox.BackgroundImage = Properties.Resources._default;
                pictureBox.Visible = true;
            }
            card1 = 0;
            cardinfo1 = null;
            card2 = 0;
            cardinfo2 = null;
            for (int r = 0; r < 16; r++)
            {
                cardproperties[r, 1] = 0;
            }
            scramble();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rotate(sender, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rotate(sender, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rotate(sender, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rotate(sender, 3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rotate(sender, 4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rotate(sender, 5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rotate(sender, 6);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            rotate(sender, 7);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            rotate(sender, 8);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            rotate(sender, 9);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            rotate(sender, 10);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            rotate(sender, 11);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            rotate(sender, 12);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            rotate(sender, 13);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            rotate(sender, 14);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            rotate(sender, 15);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
