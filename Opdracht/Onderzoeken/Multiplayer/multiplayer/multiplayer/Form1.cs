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
            mis3.Visible = false;
            mis4.Visible = false;

            if (player1.Visible == true && p1box.Text == "")
            {
                mis1.Visible = true;
            }
            else
            {
                mis1.Visible = false;
            }
            if (player2.Visible == true && p2box.Text == "")
            {
                mis2.Visible = true;
            }
            else
            {
                mis2.Visible = false;
            }

            if (player3.Visible == true && p3box.Text == "")
            {
                mis3.Visible = true;
            }
            else
            {
                p1txt.Text = p1box.Text;
                p2txt.Text = p2box.Text;
                p3txt.Text = p3box.Text;
                p4txt.Text = p4box.Text;
            }
        }
    }
}
