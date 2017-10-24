using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamisch_speelveld
{
    public partial class Dynamisch : Form
    {

        public Dynamisch()
        {
            InitializeComponent();
            string[] playerArr = new string[] { "1 Player", "2 Players", "3 Players", "4 Players" };
            string[] diffArr = new string[] { "Very Easy", "Easy", "Normal", "Hard", "Extreme" };

            System.Windows.Forms.RadioButton[] diffButtons = new System.Windows.Forms.RadioButton[5];
            System.Windows.Forms.RadioButton[] playerButtons = new System.Windows.Forms.RadioButton[5];
            //System.Windows.Forms.Textbox[] playerBoxes = new System.Windows.Forms.Textbox[4];
            //List<PictureBox> pictureBoxList = new List<PictureBox>();

            // Draw all of the difficulty radioButtons
            for (int d = 0; d < 5; d++)
            {
                diffButtons[d] = new RadioButton();
                diffButtons[d].Text = diffArr[d];
                diffButtons[d].Location = new System.Drawing.Point(500, 500 + d * 25);
                this.Controls.Add(diffButtons[d]);
            }
            List<PictureBox> pictureBoxList = new List<PictureBox>();
           // if (diffButtons1.Checked) //Button is nog niet aangemaakt. <<<<<<<<<<<<<<<<<<<<<<<<-x-o-x-o-x-o-x-o-x-o-x-o-x
            {
                for (int i = 0; i < 4; i++)
                {
                    PictureBox picture = new PictureBox
                    {
                        Name = "pictureBox" + i,
                        Size = new Size(100, 100),
                        Location = new Point(i * 110, 1),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    pictureBoxList.Add(picture);
                }

                foreach (PictureBox p in pictureBoxList)
                {
                    this.Controls.Add(p);
                }
            }

        }
            private void Dynamisch_Load(object sender, EventArgs e)
            {

            }
        }
    }
