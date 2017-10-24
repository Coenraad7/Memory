using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplayer
{
    public partial class multiplayer : Form
    {

        public multiplayer()
        {
            InitializeComponent();
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

        private void save_Click(object sender, EventArgs e)
        {

            if (!(p1box.Text == "") && (p2box.Visible == true && !(p2box.Text == "") || p2box.Visible == false) && (p3box.Visible == true && !(p3box.Text == "") || p3box.Visible == false) && (p4box.Visible == true && !(p4box.Text == "") || p4box.Visible == false)) && ((dif1.Checked) || (dif2.Checked) || (dif3.Checked) || (dif4.Checked) || (dif5.Checked)) && ((theme1.Checked) || (theme2.Checked) || (theme3.Checked) || (theme4.Checked) || (theme5.Checked))
            {

                {

                    if (p1box.Visible == true && p1box.Text == "")
                    {
                        p1box.BackColor = Color.Red;
                    }
                    else
                    {
                        p1txt.Text = p1box.Text;
                    }
                    if (p2box.Visible == true && p2box.Text == "")
                    {
                        p2box.BackColor = Color.Red;
                    }
                    else
                    {
                        p2txt.Text = p2box.Text;
                    }

                    if (p3box.Visible == true && p3box.Text == "")
                    {
                        p3box.BackColor = Color.Red;
                    }
                    else
                    {
                        p3txt.Text = p3box.Text;
                    }

                    if (p4box.Visible && p4box.Text == "")
                    {
                        p4box.BackColor = Color.Red;
                    }
                    else
                    {
                        p4txt.Text = p4box.Text;
                    }
                }

                {
                    MessageBox.Show("alles is goed");
                }

            }
            
            {
                MessageBox.Show("je bent iets vergeten");
            }


        }

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
