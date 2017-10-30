using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

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
            int m = 0, s = (600 / grid[(Variables.difficulty), 0]);
            for (int i = 0; i < grid[(Variables.difficulty), 0]; i++)
            {
                for (int e = 0; e < grid[(Variables.difficulty), 1]; e++)
                {
                    PictureBox box = new PictureBox();
                    box.Location = new System.Drawing.Point((200 + ((s + 10) * i)), (10 + ((s + 10) * e)));
                    box.Name = stringArray[m];
                    box.Size = new System.Drawing.Size(s, s);
                    box.BackColor = Color.White;
                    box.BackgroundImageLayout = ImageLayout.Stretch;
                    box.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "default"); ;
                    box.Click += new EventHandler(rotate);
                    Controls.Add(box);
                    m++;
                }
            }

            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + theme + "Background");
            player1txt.Text = Variables.playernames[0];
            player2txt.Text = Variables.playernames[1];
            player3txt.Text = Variables.playernames[2];
            player4txt.Text = Variables.playernames[3];
            score2txt.Text = "";
            score3txt.Text = "";
            score4txt.Text = "";
            if (Variables.amountplayers >= 2)
            {
                stopwatch.Visible = true;
                txtresult.Text = "30";
                score2txt.Text = "Score: 0";
                arrow1.Visible = true;
            }
            if (Variables.amountplayers >= 3)
            {
                score3txt.Text = "Score: 0";
            }
            if (Variables.amountplayers == 4)
            {
                score4txt.Text = "Score: 0";
            }
        }
        #region Save function
        private void button2_Click(object sender, EventArgs e)
        {
            List<spelerdetails> p1 = new List<spelerdetails>();
            List<hiscores> h1 = new List<hiscores>();
            XmlSerializer serial = new XmlSerializer(typeof(List<spelerdetails>));
            XmlSerializer hiscore = new XmlSerializer(typeof(List<hiscores>));

            p1.Add(new spelerdetails() { id = 1, speler = player1txt.Text, score = score1txt.Text});
            h1.Add(new hiscores() { naam = player1txt.Text, hiscore = score1txt.Text });

            if (Variables.amountplayers >= 2)
            {
                p1.Add(new spelerdetails() { id = 2, speler = player2txt.Text, score = score2txt.Text });
            }
            if (Variables.amountplayers >= 3)
            {
                p1.Add(new spelerdetails() { id = 3, speler = player3txt.Text, score = score3txt.Text });
            }
            if (Variables.amountplayers == 4)
            {
                p1.Add(new spelerdetails() { id = 4, speler = player4txt.Text, score = score4txt.Text });
            }
            using (FileStream fs = new FileStream(Environment.CurrentDirectory+ "\\spelers.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
                MessageBox.Show("game Saved");
            }
        }
        #endregion
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

                if (score > Convert.ToInt32(Variables.highscoresscore[Variables.difficulty,9]))
                {
                    int spot = 9;
                    for (int i = 8; i >= 0; i--)
                    {
                        if (score > Variables.highscoresscore[Variables.difficulty,i])
                        {
                            Variables.highscoresscore[Variables.difficulty, (i + 1)] = Variables.highscoresscore[Variables.difficulty, i];
                            Variables.highscoresplayer[Variables.difficulty, (i + 1)] = Variables.highscoresplayer[Variables.difficulty, i];
                            spot--;
                        }
                    }
                    Variables.highscoresscore[Variables.difficulty, spot] = score;
                    Variables.highscoresplayer[Variables.difficulty, spot] = player1txt.Text;
                }
            }
        }
#endregion
        #region score
        public void keepscore(bool correct) //methode voor bij houden van score en het toepassen van de multiplier
        { 
            if (Variables.amountplayers == 1)
            {
                if (correct == true)
                {
                    score1 += Convert.ToInt32(multiplier * 10);
                    score1txt.Text = "Score: " + score1;

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
                stopwatch.Visible = true;
                {
                    if (correct == true)
                    {
                        if (turn == 1)
                        {
                            score1 += Convert.ToInt32(winst);
                            score1txt.Text = "Score: " + Convert.ToString(score1);
                            timers();
                        }
                        else if (turn == 2)
                        {
                            score2 += Convert.ToInt32(winst);
                            score2txt.Text = "Score: " + Convert.ToString(score2);
                            timers();
                        }
                        else if (turn == 3 && Variables.amountplayers >= 3)
                        {
                            score3 += Convert.ToInt32(winst);
                            score3txt.Text = "Score: " + Convert.ToString(score3);
                            timers();

                        }
                        else if (turn == 4 && Variables.amountplayers == 4)
                        {
                            score4 += Convert.ToInt32(winst);
                            score4txt.Text = "Score: " + Convert.ToString(score4);
                            timers();
                        }
                    }
                    else if (correct == false)
                    {
                        if (turn != Variables.amountplayers)
                        {
                            turn += 1;
                            timers();
                        }
                        else
                        {
                            turn = 1;
                            timercount++;
                            timers();
                        }
                    }
                    if (turn == 2) { arrow1.Visible = false; arrow2.Visible = true; }
                    if (turn == 3) { arrow2.Visible = false; arrow3.Visible = true; }
                    if (turn == 4) { arrow3.Visible = false; arrow4.Visible = true; }
                    if (turn == 1)
                    {
                        arrow2.Visible = false;
                        arrow3.Visible = false;
                        arrow4.Visible = false;
                        arrow1.Visible = true;
                    }
                }
            }
        }
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
        }
        #endregion
        #region Timers
        public void timer1_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer1.Stop();
                keepscore(false);
            }
        }

        private void timers()
        {
            timer1.Stop();
            if (timercount == 1)
            {
                txtresult.Text = "30";
            }
            else if (timercount == 2)
            {
                txtresult.Text = "25";
            }
            else if (timercount == 3)
            {
                txtresult.Text = "20";
            }
            else
            {
                txtresult.Text = "15";
            }
            timer1.Start();
        }
    }
        #endregion
}

