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
