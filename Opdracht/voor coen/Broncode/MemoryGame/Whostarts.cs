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
    /// <summary>Class Whostarts</summary>
    /// <para>This class is opened on a multiplayer game and decides the starting player</para>
    public partial class Whostarts : Form
    {
        int ran;
        /// <summary>Method Whostarts</summary>
        /// <para>Default method, starts timer and edits the starting interval</para>
        public Whostarts()
        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Start();
        }
        /// <summary>Method timer1_Tick</summary>
        /// <para>Creator Richard: Increases the interval and calls random()</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval += 50;
            random();
        }
        /// <summary>Method random</summary>
        /// <para>Creator Richard: Generates a random number depending on amount of players and when the timer interval reaches a set amount will run open MainGame.cs and closes Whostarts.cs</para>
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
