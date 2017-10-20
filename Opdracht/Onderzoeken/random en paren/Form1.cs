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
        int[,] cardproperties;
        int count,card1,card2,oldcard = -1,oldcard2 = -1;
        PictureBox cardinfo1,cardinfo2;
        int score = 0;
        double winst = 10, multiplier = 1;

        public Form1()
        {
            InitializeComponent();
            int amount = 16; //aantal kaarten die gebruikt worden
            cardproperties = new int[amount, 2]; //1e getal is kaartnummer/picturebox, 2e getal is een property ,1 is bvb paarnummer(bij 16 kaarten 1tm8)
            scramble(); //spel begin kaarten randomizen
        }

        private void scramble()
        {
            Random rng = new Random();
            bool check;
            int random;

            for (int i = 0; i < cardproperties.GetLength(0); i++) //cardproperties.GetLength(0) houd in dat hij de lengte bekijkt van de eerste indice
            {
                check = true;
                random = rng.Next(1, (cardproperties.GetLength(0) / 2 + 1));
                for (int e = 0; e < cardproperties.GetLength(0); e++)
                {
                    if ((cardproperties[e, 1] == random) && (check == true)) //1e check dat er 1 nummer instaat (dit mag wel)
                    {
                        check = false;
                    }
                    else if ((cardproperties[e, 1] == random) && (check == false)) //2e check dat er een nummer 2x instaat (dit mag niet en alles word gereset zodra dit bekend is)
                    {
                        e = -1;
                        check = true;
                        random = rng.Next(1, (cardproperties.GetLength(0) / 2 + 1));
                    }
                }
                cardproperties[i, 1] = random; //nummer aan de array 
            }
        }

        private void rotate(object sender, int picture)
        {
            PictureBox card = (PictureBox)sender;
            card.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + cardproperties[picture,1]); //kaartje naar juiste backgroundimage zetten (afhankelijk van paarnummer)

            if (card1 == 0) //1e klik (word maar 1x gedraaid in de code)
            {
                card1 = cardproperties[picture, 1];
                cardinfo1 = card;
                oldcard = picture;
            }
            else if (card1 != 0 && card2 == 0 && oldcard != picture) //2e klik
            {
                card2 = cardproperties[picture, 1];
                cardinfo2 = card;
                oldcard2 = picture;
                paircheck(); //hier word de methode voor het controlleren van paren opgevraagd
            }
            else if (card2 != 0 && oldcard != picture && oldcard2 != picture) //3e klik en ook 1e (omdat de 3e klik ook een kaartje registreerd)
            {
                cardinfo1.BackgroundImage = Properties.Resources._default;
                cardinfo2.BackgroundImage = Properties.Resources._default;
                card1 = cardproperties[picture, 1];
                cardinfo1 = card;
                oldcard = picture;
                card2 = 0;
                cardinfo2 = null;
                keepscore(false);
            }
        }

        private void paircheck()
        {
            if (card1 == card2) //als de waarden gelijk zijn zal hij ze terug zetten naar standaard(_default) en verstoppen
            {
                cardinfo1.BackgroundImage = Properties.Resources._default;
                cardinfo2.BackgroundImage = Properties.Resources._default;
                cardinfo1.Visible = false;
                cardinfo2.Visible = false;
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
                keepscore(true);
            }
        }

        private void keepscore(bool correct) //methode voor bij houden van score en het toepassen van de multiplier
        {
            if (correct == true)
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
            else if (correct == false)
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
            label1.Text = "Score: " + Convert.ToString(score);
        }

        private void Reset()
        {
            foreach (var pictureBox in Controls.OfType<PictureBox>()) //vraagt alle picture boxes op
            {
                string name = pictureBox.Name;
                if (Convert.ToInt32(name.Replace("pictureBox", "")) <= cardproperties.GetLength(0)) //vergelijkt de namen van de pictureboxes met de cards die gebruikt worden en reset ze naar _default en visible (voorkomen dat andere pictureboxes worden aangepast)
                {
                    pictureBox.BackgroundImage = Properties.Resources._default;
                    pictureBox.Visible = true;
                }
                else
                {
                    break;
                }
            }
            card1 = 0; //alle code die hier staat zorgt er voor dat de standaard waarden terug worden gezet
            cardinfo1 = null;
            card2 = 0;
            cardinfo2 = null;
            for (int r = 0; r < cardproperties.GetLength(0); r++)
            {
                cardproperties[r, 1] = 0;
            }
            score = 0;
            label1.Text = "Score: 0";
            scramble(); //vraagt scramble op om zo de kaartjes te husselen
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rotate(sender, 0); //rotate is een methode voor het omdraaien van de kaartjes, sender geeft de informatie mee van de picturebox, 0 geeft aan dat hij slot 0 gebruikt in de array (cardproperties[0,*])
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
    }
}
