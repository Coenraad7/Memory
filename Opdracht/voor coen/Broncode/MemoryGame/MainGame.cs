﻿using System;
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
using System.Xml;

namespace MemoryGame
{
    /// <summary>Class MainGame</summary>
    /// <para>This is the maingame class and contains most of the code used for the memorygame itself.</para>
    public partial class MainGame : Form
    {
        /// <summary>Variables in Class Maingame</summary>
        /// <para>public int Turn: keeps track of what players turn it is. only used in multiplayer and is given a value from Whostarts.</para>
        /// <Para>int[,] cardproperties: Contains info of every picturebox. [x.y] x = picturebox number, y = pairnumber and visible(0 or 1).</Para>
        /// <para>int[,] grid: contains a set ammount of values depending on the difficulty level.</para>
        /// <para>int[] scores: keeps track of every player score in the current game.</para>
        /// <para>int card1, card2: Contains pairnumbers from the last picture boxes that have been clicked.</para>
        /// <para>int picture1, picture2: remembers the cardproperties number for when they can be removed.</para>
        /// <para>int count: keeps track of the ammount of cards that have been played away.</para>
        /// <para>int timercount: this value helps decreasing the timers time and increases when all the players had their turn.</para>
        /// <para>PictureBox cardinfo1, cardinfo2: Contains the picturebox information from the last 2 picturebox clicks.</para>
        /// <para>double multiplier: keeps track of a multiplier for the scoring system in SINGLEPLAYER.</para>
        public int turn;
        int[,] cardproperties, grid = new int[5, 3] { { 4, 4, 16 }, { 5, 4, 20 }, { 6, 4, 24 }, { 6, 5, 30 }, { 6, 6, 36 } };
        int[] scores = new int[4] { 0, 0, 0, 0 };
        int card1, card2, picture1, picture2, count, timercount = 0;
        PictureBox cardinfo1, cardinfo2;
        double multiplier = 1;
        /// <summary>Method MainGame</summary>
        /// <para>default method</para>
        public MainGame()
        {
            InitializeComponent();
        }
        /// <summary>Method MainGame_Load</summary>
        /// <para>Runs code when the form loads. this depends on the Variables.Loadgame</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MainGame_Load(object sender, EventArgs e)
        {
            if (Variables.loadgame == 1)
            {
                Loadgame();
                init(); //maakt speelveld aan en geeft de juiste theme mee.
                initspecial(); //voor het inladen van de al omgedraaide kaarten ALLEEN DRAAIEN NA LADEN SPEL EN LADEN INIT()
                Variables.loadgame = 3;
            }
            else
            {
                init(); //maakt speelveld aan en geeft de juiste theme mee.
                scramble(); //spel begin kaarten randomizen
            }
        }
        /// <summary>Method init</summary>
        /// <para>Creator Richard: init initizalizes most of the game. It creates pictureboxes, empties textboxes and fills them accordingly. Mostely depends on difficulty, amountplayers.</para>
        private void init()
        {
            string[] stringArray = new string[grid[Variables.difficulty, 2]];
            for (int i = 0; i < grid[Variables.difficulty, 2]; i++)
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
                    box.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + "default"); ;
                    box.Click += new EventHandler(rotate);
                    Controls.Add(box);
                    m++;
                }
            }

            this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + "Background");
            player1txt.Text = Variables.playernames[0];
            player2txt.Text = "";
            player3txt.Text = "";
            player4txt.Text = "";
            score1txt.Text = "Score: " + scores[0];
            score2txt.Text = "";
            score3txt.Text = "";
            score4txt.Text = "";

            if (Variables.amountplayers >= 2)
            {
                if (turn == 1)
                {
                    arrow1.Visible = true;
                }
                else if (turn == 2)
                {
                    arrow2.Visible = true;
                }
                else if (turn == 3)
                {
                    arrow3.Visible = true;
                }
                else if (turn == 4)
                {
                    arrow4.Visible = true;
                }

                txtresult.Visible = true;
                stopwatch.Visible = true;
                
                timers();
                player2txt.Text = Variables.playernames[1];
                score2txt.Text = "Score: " + scores[1];
            }
            if (Variables.amountplayers >= 3)
            {
                player3txt.Text = Variables.playernames[2];
                score3txt.Text = "Score: " + scores[2];
            }
            if (Variables.amountplayers == 4)
            {
                player4txt.Text = Variables.playernames[3];
                score4txt.Text = "Score: " + scores[3];
            }
        }
        /// <summary>Method initspecial</summary>
        /// <para>This method only runs when a continue game is selected. it makes the pictureboxes that have been played away invisible.</para>
        private void initspecial()
        {
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                try
                {
                    string temp = pb.Name;
                    int picture = ((Convert.ToInt32(temp.Replace("pictureBox", ""))) - 1);

                    if (cardproperties[picture, 1] == 1)
                    {
                        pb.Visible = false;
                    }
                }
                catch
                {

                }
            }
        }

        #region save & load
        /// <summary>Method Savegame</summary>
        /// <para>Creator Richard/Johnny: This method loads all necessary variables to a .sav file</para>
        private void Savegame()
        {
            XmlTextWriter writer = new XmlTextWriter("memorysave.sav", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("values");
            writer.WriteStartElement("ints");

            writer.WriteElementString("player1_name", Convert.ToString(Variables.playernames[0]));
            writer.WriteElementString("thema_game", Convert.ToString(Variables.theme));
            writer.WriteElementString("Moeilijkheidgraad", Convert.ToString(Variables.difficulty));
            writer.WriteElementString("aantalspelers", Convert.ToString(Variables.amountplayers));

            writer.WriteElementString("player1_score", Convert.ToString(scores[0]));
            writer.WriteElementString("count", Convert.ToString(count));

            if (Variables.amountplayers == 1)
            {
                writer.WriteElementString("Multiplier", Convert.ToString(multiplier));
            }
            else if (Variables.amountplayers >= 2)
            {
                writer.WriteElementString("turn", Convert.ToString(turn));
                writer.WriteElementString("Timer", Convert.ToString(timercount));
                writer.WriteElementString("player2_name", Convert.ToString(Variables.playernames[1]));
                writer.WriteElementString("player2_score", Convert.ToString(scores[1]));
                if (Variables.amountplayers >= 3)
                {
                    writer.WriteElementString("player3_score", Convert.ToString(scores[2]));
                    writer.WriteElementString("player3_name", Convert.ToString(Variables.playernames[2]));
                    if (Variables.amountplayers >= 4)
                    {
                        writer.WriteElementString("player4_name", Convert.ToString(Variables.playernames[3]));
                        writer.WriteElementString("player4_score", Convert.ToString(scores[3]));
                    }
                }
            }
            writer.WriteEndElement();   //sluiten van element "ints"
            writer.WriteStartElement("array");
            for (int i = 0; i < cardproperties.GetLength(0); i++)
            {
                writer.WriteElementString("cardproperties" + i + 0, Convert.ToString(cardproperties[i, 0]));
                writer.WriteElementString("cardproperties" + i + 1, Convert.ToString(cardproperties[i, 1]));
            }
            writer.WriteEndElement();   //sluiten van element "array"
            writer.WriteEndElement();   //sluiten van element "values"
            writer.Close();
        }
        /// <summary>Method Loadgame</summary>
        /// <para>Creator Richard/Johnny: This method loads all necessary variables to a .sav file</para>
        private void Loadgame()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("memorysave.sav");

            Variables.theme = Convert.ToInt32(doc.SelectSingleNode("values/ints/thema_game").InnerText);
            Variables.difficulty = Convert.ToInt32(doc.SelectSingleNode("values/ints/Moeilijkheidgraad").InnerText);
            Variables.amountplayers = Convert.ToInt32(doc.SelectSingleNode("values/ints/aantalspelers").InnerText);
            Variables.playernames[0] = (doc.SelectSingleNode("values/ints/player1_name").InnerText); 
            scores[0] = Convert.ToInt32(doc.SelectSingleNode("values/ints/player1_score").InnerText);
            count = Convert.ToInt32(doc.SelectSingleNode("values/ints/count").InnerText);
            
            if (Variables.amountplayers == 1)
            {
                multiplier = Convert.ToDouble(doc.SelectSingleNode("values/ints/Multiplier").InnerText);
            }
            else if (Variables.amountplayers >= 2)
            {
                turn = Convert.ToInt32(doc.SelectSingleNode("values/ints/turn").InnerText);
                timercount = Convert.ToInt32(doc.SelectSingleNode("values/ints/Timer").InnerText);
                Variables.playernames[1] = Convert.ToString(doc.SelectSingleNode("values/ints/player2_name").InnerText);
                scores[1] = Convert.ToInt32(doc.SelectSingleNode("values/ints/player2_score").InnerText);
                if (Variables.amountplayers >= 3)
                {
                    Variables.playernames[2] = Convert.ToString(doc.SelectSingleNode("values/ints/player3_name").InnerText);
                    scores[2] = Convert.ToInt32(doc.SelectSingleNode("values/ints/player3_score").InnerText);
                    if (Variables.amountplayers == 4)
                    {
                        Variables.playernames[3] = Convert.ToString(doc.SelectSingleNode("values/ints/player4_name").InnerText);
                        scores[3] = Convert.ToInt32(doc.SelectSingleNode("values/ints/player4_score").InnerText);
                    }
                }
            }
            cardproperties = new int[grid[Variables.difficulty, 2], 2];
            for (int i = 0; i < cardproperties.GetLength(0); i++)
            {
                cardproperties[i, 0] = Convert.ToInt32(doc.SelectSingleNode("values/array/cardproperties"+ i + 0).InnerText);
                cardproperties[i, 1] = Convert.ToInt32(doc.SelectSingleNode("values/array/cardproperties"+ i + 1).InnerText);
            }
        }
        #endregion
        #region scramble funtions
        /// <summary>Method scramble</summary>
        /// <para>Creator Richard: This method initializes the cardproperties array and fills it with randomized number variating per difficulty. every number will be created only twice and will act as a pair in the game.</para>
        private void scramble()
        {
            cardproperties = new int[grid[Variables.difficulty, 2], 2]; //1e getal is kaartnummer/picturebox, 2e getal is een property ,1 is bvb paarnummer(bij 16 kaarten 1tm8)
            Random rng = new Random();
            bool check;
            int random;

            for (int i = 0; i < grid[Variables.difficulty, 2]; i++) //grid[Variables.difficulty,2] is het aantal kaarten dat gebruikt word
            {
                check = true;
                random = rng.Next(1, (grid[Variables.difficulty, 2] / 2 + 1));
                for (int e = 0; e < grid[Variables.difficulty, 2]; e++)
                {
                    if ((cardproperties[e, 0] == random) && (check == true)) //1e check dat er 1 nummer instaat (dit mag wel)
                    {
                        check = false;
                    }
                    else if ((cardproperties[e, 0] == random) && (check == false)) //2e check dat er een nummer 2x instaat (dit mag niet en alles word gereset zodra dit bekend is)
                    {
                        e = -1;
                        check = true;
                        random = rng.Next(1, (grid[Variables.difficulty, 2] / 2 + 1));
                    }
                }
                cardproperties[i, 0] = random; //nummer aan de array 
            }
        }
        #endregion
        #region Rotate/cards functions
        /// <summary>Method rotate</summary>
        /// <para>Creator Richard: This method is called when a picture box is clicked. it acts as a rotation in the memory game because the picture will change. after the second click it will also call paircheck() to check the cards. if the 3th card is clicked to fast it will also call Undorotate().</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rotate(object sender, EventArgs e)
        {
            string temp = (sender as PictureBox).Name;
            int picture = ((Convert.ToInt32(temp.Replace("pictureBox", ""))) - 1);
            if (card1 != 0 && card2 != 0) //3e kaart click als ze nog niet zijn omgedraaid
            {
                undorotate();
            }

            PictureBox card = (PictureBox)sender;
            card.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + cardproperties[picture, 0]); //kaartje naar juiste backgroundimage zetten (afhankelijk van paarnummer)

            if (card1 == 0) //1e klik
            {
                card1 = cardproperties[picture, 0]; //onhouden wat het paarnummer is van 1e kaart
                cardinfo1 = card; //onhouden wat de 1e kaart is
                card.Enabled = false; //zorgt ervoor dat het kaartje niet meer klikbaar is
                picture1 = picture;
            }
            else //2e klik
            {
                card2 = cardproperties[picture, 0];
                cardinfo2 = card;
                card.Enabled = false;
                picture2 = picture;
                paircheck(); //hier word de methode voor het controlleren van paren opgevraagd
            }
        }
        /// <summary>Method undorotate</summary>
        /// <para>Creator Richard: undo's the rotated cards after it is called. This results in that you are able to view the cards before they are invisible or back to the default background.</para>
        private void undorotate() //reset na 0,4 seconden
        {
            undo.Stop();
            if (card1 != card2) 
            {
                cardinfo1.Enabled = true;
                cardinfo2.Enabled = true;
                cardinfo1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + "default");
                cardinfo2.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + "default");
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
            }
            else if (card1 == card2)
            {
                cardinfo1.Visible = false;
                cardinfo2.Visible = false;
                card1 = 0;
                cardinfo1 = null;
                card2 = 0;
                cardinfo2 = null;
                cardproperties[picture1, 1] = 1;
                cardproperties[picture2, 1] = 1;
            }
        }
        /// <summary>Method paircheck</summary>
        /// <para>Creator Richard: This method will compares the values of card1 and card2. if they have the same value it will call Keepscore(true) and add 2 to the count. it also checks if the game is finished or not. if the cards arent the same Keepscore(false) will be called.</para>
        private void paircheck()
        {
            if (card1 == card2) //als de waarden gelijk zijn zal hij ze terug zetten naar standaard(_default) en verstoppen
            {
                keepscore(true);
                count +=2;

                if (count == grid[Variables.difficulty, 2]) //checkt of count gelijk is aan het aantal kaarten en bepaald dus of het spel klaar is
                {
                    timer1.Stop();
                    stopwatch.Visible = false;
                    txtresult.Text = "";
                    arrow1.Visible = false;
                    arrow2.Visible = false;
                    arrow3.Visible = false;
                    arrow4.Visible = false;

                    if (Variables.amountplayers == 1 && scores[0] > Convert.ToInt32(Variables.highscoresscore[Variables.difficulty, 9])) //checkt of de behaalde score van een singleplayer game highscore waardig is.
                    {
                        highscore();
                    }
                    if (Variables.loadgame == 3)
                    {
                        File.Delete("memorysave.sav");
                        Variables.loadgame = 0;
                    }
                    Endscreen endscreen =  new Endscreen();
                    endscreen.scores[0] = scores[0];
                    endscreen.scores[1] = scores[1];
                    endscreen.scores[2] = scores[2];
                    endscreen.scores[3] = scores[3];
                    endscreen.MdiParent = this.ParentForm;
                    endscreen.Show();
                    Close();
                }
            }
            else
            {
                keepscore(false);
            }
            undo.Start();
        }
        #endregion
        #region score/highscore
        /// <summary>Method keepscore</summary>
        /// <para>Creator Richard: This is a method in the MainGame class/form. It makes sure the players get a score when correct = true. if its not it will rotate to the next player or decreases Multiplier.</para>
        /// <param name="correct"></param>
        public void keepscore(bool correct) //methode voor bij houden van score en het toepassen van de multiplier
        { 
            if (Variables.amountplayers == 1)
            {
                if (correct == true)
                {
                    scores[0] += Convert.ToInt32(multiplier * 10);
                    score1txt.Text = "Score: " + scores[0];

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
                            scores[0]++;
                            score1txt.Text = "Score: " + Convert.ToString(scores[0]);
                        }
                        else if (turn == 2)
                        {
                            scores[1]++;
                            score2txt.Text = "Score: " + Convert.ToString(scores[1]);
                        }
                        else if (turn == 3 && Variables.amountplayers >= 3)
                        {
                            scores[2]++;
                            score3txt.Text = "Score: " + Convert.ToString(scores[2]);
                        }
                        else if (turn == 4 && Variables.amountplayers == 4)
                        {
                            scores[3]++;
                            score4txt.Text = "Score: " + Convert.ToString(scores[3]);
                        }
                    }
                    else if (correct == false)
                    {
                        if (turn != Variables.amountplayers)
                        {
                            turn += 1;
                        }
                        else
                        {
                            turn = 1;
                            timercount++;
                        }  
                    }
                    timers();

                    if (turn == 2) { arrow1.Visible = false; arrow2.Visible = true; }
                    if (turn == 3) { arrow2.Visible = false; arrow3.Visible = true; }
                    if (turn == 4) { arrow3.Visible = false; arrow4.Visible = true; }
                    if (turn == 1) { arrow4.Visible = false; arrow3.Visible = false; arrow2.Visible = false; arrow1.Visible = true; }
                }
            }
        }
        /// <summary>Method highscore</summary>
        /// <para>Creator Richard: This is a method in the MainGame class/form. When a game is finished it check if the current SINGLEPLAYER score is higher than the lowest highscore of that difficulty and places it in the correct spot and saves it to highscores.sav.</para>
        private void highscore()
        {
            int spot = 9;
            for (int i = 8; i >= 0; i--)
            {
                if (scores[0] > Variables.highscoresscore[Variables.difficulty, i])
                {
                    Variables.highscoresscore[Variables.difficulty, (i + 1)] = Variables.highscoresscore[Variables.difficulty, i];
                    Variables.highscoresplayer[Variables.difficulty, (i + 1)] = Variables.highscoresplayer[Variables.difficulty, i];
                    spot--;
                }
            }
            Variables.highscoresscore[Variables.difficulty, spot] = scores[0];
            Variables.highscoresplayer[Variables.difficulty, spot] = player1txt.Text;

            XmlTextWriter writer = new XmlTextWriter("highscores.sav", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("highscores");
            for (int i = 0; i < 5; i++)
            {
                for (int e = 0; e < 10; e++)
                {
                    writer.WriteElementString("highscoresscore" + i + e, Convert.ToString(Variables.highscoresscore[i, e]));
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int e = 0; e < 10; e++)
                {
                    writer.WriteElementString("highscoresplayer" + i + e, Variables.highscoresplayer[i, e]);
                }
            }
            writer.WriteEndElement();   //sluiten van element "highscores"
            writer.Close();

        }
        #endregion
        #region Buttons
        /// <summary>Method button1_Click</summary>
        /// <para>Creator Coenraad: This button brings you back to the MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }
        /// <summary>Method reset_Click</summary>
        /// <para>Creator Richard: This button reloads the MainGame.cs and acts as a reset button.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reset_Click(object sender, EventArgs e)
        {
            if (Variables.amountplayers >= 2)
            {
                Whostarts Whostarts = new Whostarts();
                Whostarts.MdiParent = this.ParentForm;
                Whostarts.Show();
                Close();
            }
            else
            {
                MainGame MainGame = new MainGame();
                MainGame.MdiParent = this.ParentForm;
                MainGame.Show();
                Close();
            }
        }
        /// <summary>Method button2_click</summary>
        /// <para>Creator Johnny: Calls Savegame method</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Savegame();
        }
        #endregion
        #region Timers
        /// <summary>Method undo_tick</summary>
        /// <para>Creator Richard: This timer calls the undo rotate after a certain ammount of time.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void undo_Tick(object sender, EventArgs e)
        {
            undorotate();
        }
        /// <summary>Method timer1_Tick</summary>
        /// <para>Creator Johnny: This timer only works in Multiplayer and brings a timer to the screen. and ticks it down to 0 if it reaches 0 the cards will be default if needed and the next player will be able to play.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timer1_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(txtresult.Text);
            timer = timer - 1;
            txtresult.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                if (card1 != 0)
                {
                    cardinfo1.Enabled = true;
                    cardinfo1.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + Variables.theme + "default");
                    card1 = 0;
                    cardinfo1 = null;
                }
                timer1.Stop();
                keepscore(false);
            }
        }
        /// <summary>Method timers</summary>
        /// <para>Creator Johnny: This is the method that starts and stops the timer. it also decreases the timers time after all the players had their turn in a multiplayer session.</para>
        private void timers()
        {
            timer1.Stop();
            if (timercount <= 3)
            {
                txtresult.Text = Convert.ToString(30 - (5 * timercount));
            }
            else
            {
                txtresult.Text = "15";
            }
            timer1.Start();
        }
        #endregion
    }
}

