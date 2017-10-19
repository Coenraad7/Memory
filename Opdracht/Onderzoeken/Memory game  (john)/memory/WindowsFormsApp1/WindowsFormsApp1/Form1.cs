using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameWindow : Form
    {
        // variables
        int score = 0;                      // score systeem
        Random Location = new Random();       // random locatie van kaarten.
        List<Point> points = new List<Point>(); // list voor de plekken van de kaarten.
        bool again = false; // Play again button.
        PictureBox PendingImg1; // opslaan van de 1e geklikte kaart.
        PictureBox PendingImg2; // Opslaan van 2e geklikte kaart.

        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
            foreach(PictureBox picture in Cardsholder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach(PictureBox picture in Cardsholder.Controls)  // Zorgt voor random plaatsen van de kaarten.
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            
            timer1.Start();
            timer2.Start();
            #region    
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
            #endregion   
            #region timers1

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImg1.Image = Properties.Resources.Background;
            PendingImg2.Image = Properties.Resources.Background;
            PendingImg1 = null;
            PendingImg2 = null;
            ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in Cardsholder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand; 
                picture.Image = Properties.Resources.Background;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer -1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }
#endregion   // timers // timerss
        
        #region Cards 
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources._1;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card1;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card1;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard1_Click(object sender, EventArgs e)
        {
            DubCard1.Image = Properties.Resources._1;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard1;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard1;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources._2;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card2;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card2;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }

        }

        private void DubCard2_Click(object sender, EventArgs e)
        {
            DubCard2.Image = Properties.Resources._2;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard2;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard2;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources._3;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card3;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card3;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard3_Click(object sender, EventArgs e)
        {
            DubCard3.Image = Properties.Resources._3;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard3;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard3;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources._4;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card4;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card4;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard4_Click(object sender, EventArgs e)
        {
            DubCard4.Image = Properties.Resources._4;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard4;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard4;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources._5;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card5;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card5;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard5_Click(object sender, EventArgs e)
        {
            DubCard5.Image = Properties.Resources._5;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard5;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard5;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }

        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources._6;  
            if (PendingImg1 == null)
            {
                PendingImg1 = Card6;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card6;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard6_Click(object sender, EventArgs e)
        {
            DubCard6.Image = Properties.Resources._6;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard6;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard6;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag) {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources._7;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card7;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card7;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag) {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard7_Click(object sender, EventArgs e)
        {
            DubCard7.Image = Properties.Resources._7;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard7;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard7;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources._8;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card8;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card8;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard8_Click(object sender, EventArgs e)
        {
            DubCard8.Image = Properties.Resources._8;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard8;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard8;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card9_Click(object sender, EventArgs e)
        {
            Card9.Image = Properties.Resources._9;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card9;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card9;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card9.Enabled = false;
                    DubCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard9_Click(object sender, EventArgs e)
        {
            DubCard9.Image = Properties.Resources._9;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard9;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard9;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card9.Enabled = false;
                    DubCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card10_Click(object sender, EventArgs e)
        {
            Card10.Image = Properties.Resources._10;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card10;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card10;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card10.Enabled = false;
                    DubCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard10_Click(object sender, EventArgs e)
        {
            DubCard10.Image = Properties.Resources._10;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard10;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard10;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card10.Enabled = false;
                    DubCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card11_Click(object sender, EventArgs e)
        {
            Card11.Image = Properties.Resources._11;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card11;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card11;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card11.Enabled = false;
                    DubCard11.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard11_Click(object sender, EventArgs e)
        {
            DubCard11.Image = Properties.Resources._11;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard11;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard11;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card11.Enabled = false;
                    DubCard11.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card12_Click(object sender, EventArgs e)
        {
            Card12.Image = Properties.Resources._12;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card12;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card12;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card12.Enabled = false;
                    DubCard12.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard12_Click(object sender, EventArgs e)
        {
            DubCard12.Image = Properties.Resources._12;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard12;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard12;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card12.Enabled = false;
                    DubCard12.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card13_Click(object sender, EventArgs e)
        {
            Card13.Image = Properties.Resources._13;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card13;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card13;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card13.Enabled = false;
                    DubCard13.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard13_Click(object sender, EventArgs e)
        {
            DubCard13.Image = Properties.Resources._13;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard13;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard13;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card13.Enabled = false;
                    DubCard13.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card14_Click(object sender, EventArgs e)
        {
            Card14.Image = Properties.Resources._14;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card14;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card14;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card14.Enabled = false;
                    DubCard14.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard14_Click(object sender, EventArgs e)
        {
            DubCard14.Image = Properties.Resources._14;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard14;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard14;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card14.Enabled = false;
                    DubCard14.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card15_Click(object sender, EventArgs e)
        {
            Card15.Image = Properties.Resources._15;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card15;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card15;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card15.Enabled = false;
                    DubCard15.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard15_Click(object sender, EventArgs e)
        {
            DubCard15.Image = Properties.Resources._15;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard15;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard15;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card15.Enabled = false;
                    DubCard15.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card16_Click(object sender, EventArgs e)
        {
            Card16.Image = Properties.Resources._16;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card16;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card16;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card16.Enabled = false;
                    DubCard16.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard16_Click(object sender, EventArgs e)
        {
            DubCard16.Image = Properties.Resources._16;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard16;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard16;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card16.Enabled = false;
                    DubCard16.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card17_Click(object sender, EventArgs e)
        {
            Card17.Image = Properties.Resources._17;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card17;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card17;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card17.Enabled = false;
                    DubCard17.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard17_Click(object sender, EventArgs e)
        {
            DubCard17.Image = Properties.Resources._17;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard17;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard17;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card17.Enabled = false;
                    DubCard17.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void Card18_Click(object sender, EventArgs e)
        {
            Card18.Image = Properties.Resources._18;
            if (PendingImg1 == null)
            {
                PendingImg1 = Card18;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = Card18;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card18.Enabled = false;
                    DubCard18.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        private void DubCard18_Click(object sender, EventArgs e)
        {
            DubCard18.Image = Properties.Resources._18;
            if (PendingImg1 == null)
            {
                PendingImg1 = DubCard18;
            }
            else if (PendingImg1 != null && PendingImg2 == null)
            {
                PendingImg2 = DubCard18;
            }
            if (PendingImg2 != null && PendingImg2 != null)
            {
                if (PendingImg1.Tag == PendingImg2.Tag)
                {
                    PendingImg1 = null;
                    PendingImg2 = null;
                    Card18.Enabled = false;
                    DubCard18.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    timer3.Start();
                }
            }
        }

        #endregion // all the cards!

        private void button1_Click(object sender, EventArgs e)
        {
            GameWindow_Load(sender, e);
        }
    }
}
