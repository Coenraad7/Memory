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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Players_Load(object sender, EventArgs e)
        {

        }
        MainGame MainGame = new MainGame();
        private void button1_Click(object sender, EventArgs e)
        {
            MainGame.MdiParent = this.ParentForm;
            MainGame.FormClosed += MainGame_FormClosed;
            MainGame.Show();
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainGame = null;
            //throw new NotImplementedException();
        }

        private void player1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void p1box_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2box_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3box_TextChanged(object sender, EventArgs e)
        {

        }

        private void p4box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }
    }
}

// {
//            InitializeComponent();
//string[] playerArr = new string[] { "1 Player", "2 Players", "3 Players", "4 Players" };
//string[] diffArr = new string[] { "Very Easy", "Easy", "Normal", "Hard", "Extreme" };

//System.Windows.Forms.RadioButton[] diffButtons = new System.Windows.Forms.RadioButton[5];
//System.Windows.Forms.RadioButton[] playerButtons = new System.Windows.Forms.RadioButton[5];
//            //System.Windows.Forms.Textbox[] playerBoxes = new System.Windows.Forms.Textbox[4];
//            //List<PictureBox> pictureBoxList = new List<PictureBox>();

//            // Draw all of the difficulty radioButtons
//            for (int d = 0; d< 5; d++)
//            {
//                diffButtons[d] = new RadioButton();
//diffButtons[d].Text = diffArr[d];
//                diffButtons[d].Location = new System.Drawing.Point(500, 500 + d* 25);
//                this.Controls.Add(diffButtons[d]);
//            }
//List<PictureBox> pictureBoxList = new List<PictureBox>();
//           // if (diffButtons1.Checked) //Button is nog niet aangemaakt. <<<<<<<<<<<<<<<<<<<<<<<<-x-o-x-o-x-o-x-o-x-o-x-o-x
//            {
//                for (int i = 0; i< 4; i++)
//                {
//                    PictureBox picture = new PictureBox
//                    {
//                        Name = "pictureBox" + i,
//                        Size = new Size(100, 100),
//                        Location = new Point(i * 110, 1),
//                        BorderStyle = BorderStyle.FixedSingle,
//                        SizeMode = PictureBoxSizeMode.Zoom
//                    };
//pictureBoxList.Add(picture);
//                }

//                foreach (PictureBox p in pictureBoxList)
//                {
//                    this.Controls.Add(p);
//                }