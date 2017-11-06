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
    public partial class Endscreen : Form
    {
        public int[] scores = new int[4] { 0, 0, 0, 0 };

        public Endscreen()
        {
            InitializeComponent();
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Players form3 = new Players();
            form3.MdiParent = this.ParentForm;
            form3.Show();
            Close();
        }

        private void List()
        {

            if (Variables.amountplayers == 1)
            {
                place1.Text = "You finished with a score of: " + scores[0];
                button2.Text = "Retry?";
            }
            if (Variables.amountplayers >= 2)
            {
                if (scores[0] == scores[1])
                {
                    winlabel.Text = "You Tied";
                    drawlabel.Text = "You both have a score of: " + scores[0];
                    drawlabel.Visible = true;
                    place1.Visible = false;
                }
                else
                {
                    if (Math.Max(scores[0], scores[1]) == scores[0])
                    {
                        place1.Text = Variables.playernames[0] + " won with a score of: " + scores[0];
                        place2.Text = Variables.playernames[1] + " finished with a score of: " + scores[1];
                    }

                    else
                    {
                        place1.Text = Variables.playernames[1] + " won with a score of: " + scores[1];
                        place2.Text = Variables.playernames[0] + " finished with a score of: " + scores[0];
                    }
                    place2.Visible = true;
                }
            }
            if (Variables.amountplayers >= 3)
            {
                if (Math.Max(scores[0], Math.Max(scores[1], scores[2])) == scores[0])
                {
                    place1.Text = Variables.playernames[0] + " won with a score of: " + scores[0];

                    if (Math.Max(scores[1], scores[2]) == scores[1])
                    {
                        place2.Text = Variables.playernames[1] + " finished 2nd with a score of: " + scores[1];
                        place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                    }
                    else
                    {
                        place2.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                    }
                }
                else if (Math.Max(scores[0], Math.Max(scores[1], scores[2])) == scores[1])
                {
                    place1.Text = Variables.playernames[1] + " won with a score of: " + scores[1];

                    if (Math.Max(scores[0], scores[2]) == scores[0])
                    {
                        place2.Text = Variables.playernames[0] + " finished 2nd with a score of: " + scores[0];
                        place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                    }
                    else
                    {
                        place2.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        place3.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                    }
                }
                else
                {
                    place1.Text = Variables.playernames[2] + " won with a score of: " + scores[2];

                    if (Math.Max(scores[1], scores[2]) == scores[1])
                    {
                        place2.Text = Variables.playernames[1] + " finished 2nd with a score of: " + scores[1];
                        place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                    }
                    else
                    {
                        place2.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                    }

                }

                place3.Visible = true;
            }

            if (Variables.amountplayers == 4)
            {
                if (Math.Max(scores[0], Math.Max(scores[1], Math.Max(scores[2], scores[3]))) == scores[0])
                {
                    #region als player 1 wint
                    place1.Text = Variables.playernames[0] + " won with a score of: " + scores[0];
                    winlabel.Text = Variables.playernames[0] + " won";

                    if (Math.Max(scores[1], Math.Max(scores[2], scores[3])) == scores[1])
                    {
                        place2.Text = Variables.playernames[1] + " finished 2nd with a score of: " + scores[1];
                        if (Math.Max(scores[2], scores[3]) == scores[2])
                        {
                            place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[2];
                        }
                    }
                    else if (Math.Max(scores[1], Math.Max(scores[2], scores[3])) == scores[2])
                    {
                        place2.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        if (Math.Max(scores[1], scores[3]) == scores[1])
                        {
                            place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[3] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                    }
                    else
                    {
                        place2.Text = Variables.playernames[3] + " finished 2nd with a score of: " + scores[3];
                        if (Math.Max(scores[1], scores[2]) == scores[1])
                        {
                            place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[2] + " finished 4th with a score of: " + scores[2];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                    }
                }
                #endregion
                else if (Math.Max(scores[0], Math.Max(scores[1], Math.Max(scores[2], scores[3]))) == scores[1])
                {
                    #region als player 2 wint;
                    place1.Text = Variables.playernames[1] + " won with a score of: " + scores[1];
                    winlabel.Text = Variables.playernames[1] + " won";

                    if (Math.Max(scores[0], Math.Max(scores[2], scores[3])) == scores[0])
                    {
                        place2.Text = Variables.playernames[0] + " finished 2nd with a score of: " + scores[0];
                        if (Math.Max(scores[2], scores[3]) == scores[2])
                        {
                            place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[3] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[2] + " finished 4th with a score of: " + scores[2];
                        }
                    }
                    else if (Math.Max(scores[0], Math.Max(scores[2], scores[3])) == scores[2])
                    {
                        place2.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        if (Math.Max(scores[0], scores[3]) == scores[0])
                        {
                            place3.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[3] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                    else
                    {
                        place2.Text = Variables.playernames[3] + " finished 2nd with a score of: " + scores[3];
                        if (Math.Max(scores[0], scores[2]) == scores[0])
                        {
                            place3.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[2] + " finished 4th with a score of: " + scores[2];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                }
                #endregion
                else if (Math.Max(scores[0], Math.Max(scores[1], Math.Max(scores[2], scores[3]))) == scores[1])
                {
                    #region als player 3 wint;
                    place1.Text = Variables.playernames[2] + " won with a score of: " + scores[2];
                    winlabel.Text = Variables.playernames[2] + " won";

                    if (Math.Max(scores[0], Math.Max(scores[1], scores[3])) == scores[0])
                    {
                        place1.Text = Variables.playernames[0] + " finished 2nd with a score of: " + scores[0];
                        if (Math.Max(scores[1], scores[3]) == scores[1])
                        {
                            place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[3] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                    }
                    else if (Math.Max(scores[0], Math.Max(scores[1], scores[3])) == scores[1])
                    {
                        place1.Text = Variables.playernames[1] + " finished 2nd with a score of: " + scores[1];
                        if (Math.Max(scores[0], scores[3]) == scores[0])
                        {
                            place3.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[3] + " finished 4th with a score of: " + scores[3];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[3] + " finished 3rd with a score of: " + scores[3];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                    else
                    {
                        place1.Text = Variables.playernames[3] + " finished 2nd with a score of: " + scores[3];
                        if (Math.Max(scores[0], scores[1]) == scores[0])
                        {
                            place3.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                        else
                        {
                            place3.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                    #endregion
                }
                else
                {
                    #region als player 4 wint;
                    place1.Text = Variables.playernames[3] + " won with a score of: " + scores[3];
                    winlabel.Text = Variables.playernames[3] + " won";

                    if (Math.Max(scores[0], Math.Max(scores[1], scores[2])) == scores[0])
                    {
                        place1.Text = Variables.playernames[0] + " finished 2nd with a score of: " + scores[0];
                        if (Math.Max(scores[1], scores[2]) == scores[1])
                        {
                            place2.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[2] + " finished 4th with a score of: " + scores[2];
                        }
                        else
                        {
                            place2.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                    }
                    else if (Math.Max(scores[0], Math.Max(scores[1], scores[2])) == scores[1])
                    {
                        place1.Text = Variables.playernames[1] + " finished 2nd with a score of: " + scores[1];
                        if (Math.Max(scores[0], scores[2]) == scores[0])
                        {
                            place2.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[2] + " finished 4th with a score of: " + scores[2];
                        }
                        else
                        {
                            place2.Text = Variables.playernames[2] + " finished 3rd with a score of: " + scores[2];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                    else
                    {
                        place1.Text = Variables.playernames[2] + " finished 2nd with a score of: " + scores[2];
                        if (Math.Max(scores[0], scores[1]) == scores[0])
                        {
                            place2.Text = Variables.playernames[0] + " finished 3rd with a score of: " + scores[0];
                            place4.Text = Variables.playernames[1] + " finished 4th with a score of: " + scores[1];
                        }
                        else
                        {
                            place2.Text = Variables.playernames[1] + " finished 3rd with a score of: " + scores[1];
                            place4.Text = Variables.playernames[0] + " finished 4th with a score of: " + scores[0];
                        }
                    }
                    #endregion
                }
                place4.Visible = true;
            }
        }
    }
}
