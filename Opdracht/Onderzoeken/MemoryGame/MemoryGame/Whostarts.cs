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
    public partial class Whostarts : Form
    {
        int ran;

        public Whostarts()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval += 50;
            random();
            
        }

        private void random()
        {
            
            if (timer1.Interval < 800)
            {
                Random rng = new Random();
                ran = rng.Next(0, Variables.amountplayers);
                label1.Text = "The starting player is: " + Variables.playernames[ran] + "!";
            }
            else
            {
                timer1.Stop();
                MainGame MainGame = new MainGame();
                MainGame.turn = ran + 1;
                MainGame.MdiParent = this.ParentForm;
                MainGame.Show();
                Close();
            }
        }
    }
}
