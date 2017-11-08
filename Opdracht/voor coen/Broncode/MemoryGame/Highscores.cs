using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace MemoryGame
{
    /// <summary>Class Highscores</summary>
    /// <para>Shows the highscores of every difficulty</para>
    public partial class Highscores : Form
    {
        /// <summary>Method Highscores</summary>
        /// <para>Default method</para>
        public Highscores()
        {
            InitializeComponent();
        }
        /// <summary>Method Highscores_Load</summary>
        /// <para>Creator Richard: Loads the list of very easy difficulty</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Highscores_Load(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Very Easy difficulty" + System.Environment.NewLine;
            List(0);
        }
        /// <summary>Method button1_Click</summary>
        /// <para>Creator Coenraad: Opens Mainmenu.cs and closes Highscores.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }
        /// <summary>Methods dif*_CheckedChanged</summary>
        /// <para>Creator Richard: Changes the text box to according difficulty and calls method List with the according difficulty</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dif1_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Very Easy difficulty" + System.Environment.NewLine;
            List(0);
        }

        private void dif2_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Easy difficulty" + System.Environment.NewLine;
            List(1);
        }

        private void dif3_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Normal difficulty" + System.Environment.NewLine;
            List(2);
        }

        private void dif4_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Hard difficulty" + System.Environment.NewLine;
            List(3);
        }

        private void dif5_CheckedChanged(object sender, EventArgs e)
        {
            Scores.Text = "These are the scores for the Extreme difficulty" + System.Environment.NewLine;
            List(4);
        }
        /// <summary>Method List</summary>
        /// <Para>Creator Richard: Shows every line of the highscores list depending on choses difficulty</Para>
        /// <param name="dif">Radiobutton</param>
        private void List(int dif)
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (Variables.highscoresscore[dif, i] > 0)
                {
                    Scores.Text += Variables.highscoresplayer[dif, i] + " with a score of: " + Variables.highscoresscore[dif, i] + "!" + System.Environment.NewLine;
                }
                else
                {
                    break;
                }
            }

        }
    }
}
