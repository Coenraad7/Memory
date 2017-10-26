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
    public partial class MainGame : Form
    {

        int[,] cardproperties;
        int card1, card2, theme = Variables.theme;
        PictureBox cardinfo1, cardinfo2;
        double multiplier = 1;
        int winst = 1, score1 = 0, score2 = 0, score3 = 0, score4 = 0, turn = 1,count;
        int timercount = 1;
        int[,] grid = new int[5, 3] { { 4, 4, 16 }, { 5, 4, 20 }, { 6, 4, 24 }, { 6, 5, 30 }, { 6, 6, 36 } };



        public MainGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            init(); //maakt speelveld aan en geeft de juiste theme mee.
            scramble(); //spel begin kaarten randomizen
        }



        private void init()
        {
            cardproperties = new int[grid[Variables.difficulty,2], 2]; //1e getal is kaartnummer/picturebox, 2e getal is een property ,1 is bvb paarnummer(bij 16 kaarten 1tm8)

            string[] stringArray = new string[grid[Variables.difficulty,2]];
            for (int i = 0; i < grid[Variables.difficulty,2]; i++)
            {
                stringArray[i] = "pictureBox" + (i + 1);
            }

            int m = 0;
            for (int i = 0; i < grid[(Variables.difficulty), 0]; i++)
            {
                for (int e = 0; e < grid[(Variables.difficulty), 1]; e++)
                {
                    PictureBox box = new PictureBox();
                    box.Location = new System.Drawing.Point((110 * i), (110 * e));
                    box.Name = stringArray[m];
                    box.Size = new System.Drawing.Size(100, 100);
                    box.BackColor = Color.White;
                    box.Enabled = true;
                    box.BackgroundImageLayout = ImageLayout.Stretch;
                    box.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default"); ;
                    box.Click += new EventHandler(rotate);
                    panel1.Controls.Add(box);
                    m++;
                }
            }

            panel1.BackColor = Color.Transparent;
            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "Background");
            player1txt.Text = Variables.playernames[0];
            player2txt.Text = Variables.playernames[1];
            player3txt.Text = Variables.playernames[2];
            player4txt.Text = Variables.playernames[3];
        }

        #region scramble funtions
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
        #endregion
        #region Rotate/cards functions
        private void rotate(object sender, EventArgs e)
        {
            string temp = (sender as PictureBox).Name;
            int picture = ((Convert.ToInt32(temp.Replace("pictureBox", ""))) - 1);
            if (card1 != 0 && card2 != 0) //3e kaart click als ze nog niet zijn omgedraaid
            {
                undorotate.Stop();
                cardinfo1.Enabled = true;
                cardinfo2.Enabled = true;
                cardinfo1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default");
                cardinfo2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default");
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
            }

            PictureBox card = (PictureBox)sender;
            card.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + cardproperties[picture, 1]); //kaartje naar juiste backgroundimage zetten (afhankelijk van paarnummer)

            if (card1 == 0) //1e klik
            {
                card1 = cardproperties[picture, 1]; //onhouden wat het paarnummer is van 1e kaart
                cardinfo1 = card; //onhouden wat de 1e kaart is
                card.Enabled = false; //zorgt ervoor dat het kaartje niet meer klikbaar is
            }
            else //2e klik
            {
                card2 = cardproperties[picture, 1];
                cardinfo2 = card;
                card.Enabled = false;
                paircheck(); //hier word de methode voor het controlleren van paren opgevraagd
            }
        }

        private void MainGame_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paircheck()
        {
            if (card1 == card2) //als de waarden gelijk zijn zal hij ze terug zetten naar standaard(_default) en verstoppen
            {
                cardinfo1.BackColor = Color.Transparent;
                cardinfo2.BackColor = Color.Transparent;
                cardinfo1.BackgroundImage = null;
                cardinfo2.BackgroundImage = null;
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
                keepscore(true);
                count +=2;
            }
            else
            {
                keepscore(false);
                undorotate.Start();
            }

            if (count == grid[Variables.difficulty,2] && Variables.amountplayers == 1)
            {
                string temp = score1txt.Text;
                int score = Convert.ToInt32(temp.Replace("Score: ", ""));

                if (score > Convert.ToInt32(Variables.highscoresscore[Variables.difficulty,4]))
                {
                    int spot = 10;
                    for (int i = 9; i >= 0; i--)
                    {
                        if (score > Variables.highscoresscore[Variables.difficulty,i])
                        {
                            Variables.highscoresscore[Variables.difficulty,(i + 1)] = Variables.highscoresscore[Variables.difficulty,i];
                            spot--;
                        }
                    }
                    Variables.highscoresscore[Variables.difficulty, spot] = score;
                    Variables.highscoresplayer[Variables.difficulty, spot] = player1txt.Text;
                }
            }
        }

        public void keepscore(bool correct) //methode voor bij houden van score en het toepassen van de multiplier
        {
            
            if (Variables.amountplayers == 1)
            {
                if (correct == true)
                {
                    string temp = score1txt.Text;
                    int score = Convert.ToInt32(temp.Replace("Score: ", ""));
                    score += Convert.ToInt32(multiplier * 10);
                    score1txt.Text = "Score: " + Convert.ToString(score);

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
            }
            else if (Variables.amountplayers >= 2)
            {
                {
                    if (correct == true)
                    {
                        if (turn == 1)
                        {
                            score1 += Convert.ToInt32(winst);
                            if (timercount == 1)
                            {
                                timer1.Stop();

                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }

                        }
                        else if (turn == 2)
                        {
                            score2 += Convert.ToInt32(winst);
                            if (timercount == 1)
                            {
                                timer1.Stop();

                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }
                        }
                        else if (turn == 3 && Variables.amountplayers >= 3)
                        {
                            score3 += Convert.ToInt32(winst);
                            if (timercount == 1)
                            {
                                timer1.Stop();

                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }

                        }
                        else if (turn == 4 && Variables.amountplayers == 4)
                        {
                            score4 += Convert.ToInt32(winst);
                            if (timercount == 1)
                            {
                                timer1.Stop();

                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }
                        }

                    }
                    else if (correct == false)
                    {
                        if (turn != Variables.amountplayers)
                        {
                            turn += 1;
                            if (timercount == 1)
                            {
                                timer1.Stop();

                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }

                        }
                        else
                        {
                            turn = 1;
                            timercount++;
                            if (timercount == 1)
                            {
                                timer1.Stop();
                                txtresult.Text = "30";
                                timer1.Start();
                            }
                            else if (timercount == 2)
                            {
                                timer1.Stop();
                                timer2.Stop();
                                txtresult.Text = "25";
                                timer2.Start();
                            }
                            else if (timercount == 3)
                            {
                                timer2.Stop();
                                timer3.Stop();
                                txtresult.Text = "20";
                                timer3.Start();
                            }
                            else
                            {
                                timer3.Stop();
                                timer4.Stop();
                                txtresult.Text = "15";
                                timer4.Start();
                            }
                        }
                    }
                    score1txt.Text = "Score: " + Convert.ToString(score1);
                    score2txt.Text = "Score: " + Convert.ToString(score2);
                    score3txt.Text = "Score: " + Convert.ToString(score3);
                    score4txt.Text = "Score: " + Convert.ToString(score4);
                }
            }
        }
        #endregion
        #region wat moeten we hier nog mee?
        /*
        private void Reset()
        {
            foreach (var pictureBox in Controls.OfType<PictureBox>()) //vraagt alle picture boxes op
            {
                string name = pictureBox.Name;
                if (Convert.ToInt32(name.Replace("pictureBox", "")) <= cardproperties.GetLength(0)) //vergelijkt de namen van de pictureboxes met de cards die gebruikt worden en reset ze naar _default, visible en enabled (voorkomen dat andere pictureboxes worden aangepast)
                {
                    pictureBox.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default");
                    pictureBox.Enabled = true;
                    pictureBox.BackColor = Color.White;
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
            label1.Text = "Score: 0";
            multiplier = 1;
            scramble(); //vraagt scramble op om zo de kaartjes te husselen
        }
        */
        #endregion
        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MainGame MainGame = new MainGame();
            MainGame.MdiParent = this.ParentForm;
            MainGame.Show();
            Close();
            //Reset();
        }
#endregion
        private void undorotate_Tick(object sender, EventArgs e)
        {
            if (card1 != 0 && card2 != 0) //reset na 0,4 seconden
            {
                cardinfo1.Enabled = true;
                cardinfo2.Enabled = true;
                cardinfo1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default");
                cardinfo2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default");
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
                undorotate.Stop();
            }
        }
        #region Timers
        public void timer1_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                turn++;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                turn++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                turn++;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                turn++;
            }
        }
    }
        #endregion
}

