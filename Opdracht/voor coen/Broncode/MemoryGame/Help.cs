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
    /// <summary>Class Help</summary>
    /// <para>This form is for a textbox including some help</para>
    public partial class Help : Form
    {
        /// <summary>Method Help</summary>
        /// <para>Default method</para>
        public Help()
        {
            InitializeComponent();
        }
        /// <summary>Method button1_Click</summary>
        /// <para>Creator Coenraad: Opens MainMenu.cs and closes Help.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }
        /// <summary>Method singlebut_Click</summary>
        /// <para>Creator Daniel: shows the textbox for singleplayer and hides multiplayer</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void singlebut_Click(object sender, EventArgs e)
        {
            Multiplayerbox.Visible = false;
            Singleplayerbox.Visible = true;
        }
        /// <summary>Method singlebut_Click</summary>
        /// <para>Creator Daniel: shows the textbox for multiplayer and hides singleplayer</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multibut_Click(object sender, EventArgs e)
        {
            Multiplayerbox.Visible = true;
            Singleplayerbox.Visible = false;
        }
    }
}
