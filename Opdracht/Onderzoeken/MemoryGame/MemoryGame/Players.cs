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

        private void checkform()
        {
            if (theme1.Checked) { Variables.theme = 1; }
            else if (theme2.Checked) { Variables.theme = 2; }
            else if (theme3.Checked) { Variables.theme = 3; }
            else if (theme4.Checked) { Variables.theme = 4; }
            else if (theme5.Checked) { Variables.theme = 5; }

            if (dif1.Checked) { Variables.difficulty= 0; }
            else if (dif2.Checked) { Variables.difficulty= 1; }
            else if (dif3.Checked) { Variables.difficulty= 2; }
            else if (dif4.Checked) { Variables.difficulty = 3; }
            else if (dif5.Checked) { Variables.difficulty = 4; }

            if (player1.Checked) { Variables.amountplayers = 1; }
            else if (player2.Checked) { Variables.amountplayers = 2; }
            else if (player3.Checked) { Variables.amountplayers = 3; }
            else if (player4.Checked) { Variables.amountplayers = 4; }

            Variables.playernames[0] = p1box.Text;
            Variables.playernames[1] = p2box.Text;
            Variables.playernames[2] = p3box.Text;
            Variables.playernames[3] = p4box.Text;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {

            if (!(p1box.Text == "") && ((p2box.Visible == true && !(p2box.Text == "")) || p2box.Visible == false) && ((p3box.Visible == true && !(p3box.Text == ""))
                || p3box.Visible == false) && ((p4box.Visible == true && !(p4box.Text == "")) || p4box.Visible == false))
                //Bij een x aantal spelers MOET hetzelfde aantal aan nicknames ingevult worden.
            {

                checkform();
                
                MainGame MainGame = new MainGame();
                MainGame.MdiParent = this.ParentForm;
                MainGame.FormClosed += MainGame_FormClosed;
                MainGame.Show();
                
            }
            else
            {
                if (p1box.Visible == true && p1box.Text == "")
                {
                    p1box.BackColor = Color.Red;
                }

                if (p2box.Visible == true && p2box.Text == "")
                {
                    p2box.BackColor = Color.Red;
                }

                if (p3box.Visible == true && p3box.Text == "")
                {
                    p3box.BackColor = Color.Red;
                }

                if (p4box.Visible && p4box.Text == "")
                {
                    p4box.BackColor = Color.Red;
                }
                //Als de tekstbox zichtbaar is en er staat niets in dan moet deze rood worden.

                MessageBox.Show("You forgot something");
            }
        }

        private void MainGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainGame MainGame = new MainGame();
            MainGame = null;
            //throw new NotImplementedException();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void player1_CheckedChanged(object sender, EventArgs e)
        {
            p2box.Visible = false;
            p3box.Visible = false;
            p4box.Visible = false;
        }

        private void player2_CheckedChanged(object sender, EventArgs e)
        {
            p2box.Visible = true;
            p3box.Visible = false;
            p4box.Visible = false;
        }

        private void player3_CheckedChanged(object sender, EventArgs e)
        {
            p2box.Visible = true;
            p3box.Visible = true;
            p4box.Visible = false;
        }

        private void player4_CheckedChanged(object sender, EventArgs e)
        {
            p2box.Visible = true;
            p3box.Visible = true;
            p4box.Visible = true;
        }
        //hierdoor worden alleen de hoeveelheid tekstboxen zichtbaar die aan wordt gegeven doormiddel van de "check"

        private void p1box_KeyPress(object sender, KeyPressEventArgs e)
        {
            p1box.BackColor = Color.White;
        }

        private void p2box_KeyPress(object sender, KeyPressEventArgs e)
        {
            p2box.BackColor = Color.White;
        }

        private void p3box_KeyPress(object sender, KeyPressEventArgs e)
        {
            p3box.BackColor = Color.White;
        }

        private void p4box_KeyPress(object sender, KeyPressEventArgs e)
        {
            p4box.BackColor = Color.White;
        }
    }
}
