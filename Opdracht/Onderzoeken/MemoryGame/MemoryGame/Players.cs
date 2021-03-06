﻿using System;
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
    /// <summary>Class Players</summary>
    /// <para>This is the players form it opens when you press play and gives you a set amount of settings.</para>
    public partial class Players : Form
    {
        /// <summary>Method Players</summary>
        /// <para>Default method</para>
        public Players()
        {
            InitializeComponent();
        }
        /// <summary>Method applysettings</summary>
        /// <para>Creator Daniel: changes the settings accordingly</para>
        private void applysettings()
        {
            //selecteren van het thema
            if (theme1.Checked) { Variables.theme = 1; }
            else if (theme2.Checked) { Variables.theme = 2; }
            else if (theme3.Checked) { Variables.theme = 3; }
            else if (theme4.Checked) { Variables.theme = 4; }
            else if (theme5.Checked) { Variables.theme = 5; }

            //selecteren van het de moeilijkheidsgraad
            if (dif1.Checked) { Variables.difficulty= 0; }
            else if (dif2.Checked) { Variables.difficulty= 1; }
            else if (dif3.Checked) { Variables.difficulty= 2; }
            else if (dif4.Checked) { Variables.difficulty = 3; }
            else if (dif5.Checked) { Variables.difficulty = 4; }

            //selecteren van het aantal spelers
            if (player1.Checked) { Variables.amountplayers = 1; }
            else if (player2.Checked) { Variables.amountplayers = 2; }
            else if (player3.Checked) { Variables.amountplayers = 3; }
            else if (player4.Checked) { Variables.amountplayers = 4; }

            //het weergeven van de spelernamen
            Variables.playernames[0] = p1box.Text;
            Variables.playernames[1] = p2box.Text;
            Variables.playernames[2] = p3box.Text;
            Variables.playernames[3] = p4box.Text;
        }
        /// <summary>Method nextbutton_Click</summary>
        /// <para>Creator Daniel: This button brings you to the Whostarts.cs or MainGame.cs after checking if all the settings ahve been filled in</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextbutton_Click(object sender, EventArgs e)
        {

            if (!(p1box.Text == "") && ((p2box.Visible == true && !(p2box.Text == "")) || p2box.Visible == false) && ((p3box.Visible == true && !(p3box.Text == ""))
                || p3box.Visible == false) && ((p4box.Visible == true && !(p4box.Text == "")) || p4box.Visible == false))
                //Bij een x aantal spelers MOET hetzelfde aantal aan nicknames ingevult worden.
            {

                applysettings();
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


        /// <summary>Method backbutton_Click</summary>
        /// <para>Creator Coenraad: opens MainMenu.cs and closes Players.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backbutton_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }
        /// <summary>Methods player*_CheckChanged</summary>
        /// <para>Creator Daniel: These methods show the textboxes of player names when the corresponding radiobutton is pressed</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>Methods p*box_KeyPress</summary>
        /// <para>Creator Daniel: These keypresses change the background color of a textbox back to white when something is typed in it</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>Methods pictureBox*_Click</summary>
        /// <para>Creator Daniel: Changes the radiobuttons for themes when a uses clicks on the picture of a theme.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            theme1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            theme2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            theme3.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            theme4.Checked = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            theme5.Checked = true;
        }
    }
}
