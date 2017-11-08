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
    /// <summary>Class Variables</summary>
    /// <para>Creator Richard: Contains variables that are public static and used in different forms.</para>
    class Variables
    {
        /// <summary>Variables.*</summary>
        /// <para>Playernames: is filled in from the Players.cs.</para>
        /// <para>highscoresplayer, highscorescores: contains the highscore information gets loaded in from the mainmenu and is saved to a .sav when they're changed.</para>
        /// <para>Theme, difficulty, amountplayers: these are settings that are filled in from the players.cs.</para>
        /// <para>loadgame: gets changed when the continuegame button is pressed so that MainGame.cs loads it.</para>
        public static string[] playernames = new string[4];
        public static string[,] highscoresplayer = new string[5, 10] { { "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "" }, { "", "", "", "", "", "", "", "", "", "" } };
        public static int[,] highscoresscore = new int[5, 10] { { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
        public static int theme = 1, difficulty = 2, amountplayers = 1, loadgame = 0;
    }
    /// <summary>Class MdiContainer</summary>
    /// <para>Contains mdicontainer</para>
    public partial class MdiContainer : Form
    {
        /// <summary>Method MdiContainer</summary>
        /// <para>Default method</para>
        public MdiContainer()
        {
            InitializeComponent();
        }
        /// <summary>Method Form1_Load</summary>
        /// <para>Creator Coenraad: Loads mainmenu in a MdiContainer</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.ResourceManager.GetObject("Memory_Game_Icon_48x48")));
            this.Text = "Memorygame";
            MainMenu mainmenu = new MainMenu();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            mainmenu.MdiParent = this;
            mainmenu.Show();
        }
    }
}
