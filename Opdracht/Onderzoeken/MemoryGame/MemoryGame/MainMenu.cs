using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace MemoryGame
{
    /// <summary>Class MainMenu</summary>
    /// <para>First visible menu and contains buttons for other forms.</para>
    public partial class MainMenu : Form
    {
        /// <summary>Method MainMenu</summary>
        /// <para>Default method</para>
        public MainMenu()
        {
            InitializeComponent();
        }
        /// <summary>Method MainMenu_Load</summary>
        /// <para>Creator Richard: Checks if a save file exists and shows a button to load it when the save is found.</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            loadhighscore();
            if (!(File.Exists("memorysave.sav")))
            {
                Loadbtn.Visible = false;
            }
        }

        /// <summary>Method button1_Click</summary>
        /// <para>Creator coenraad: opens Players.cs and closes MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Players form3 = new Players();
            form3.MdiParent = this.ParentForm;
            form3.Show();
            Close();
        }
        /// <summary>Method button2_Click</summary>
        /// <para>Creator coenraad: opens Highscores.cs and closes MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.MdiParent = this.ParentForm;
            Highscores.Show();
            Close();
        }
        /// <summary>Method button4_Click</summary>
        /// <para>Creator coenraad: opens Help.cs and closes MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Help Help = new Help();
            Help.MdiParent = this.ParentForm;
            Help.Show();
            Close();
        }
        /// <summary>Method button5_Click</summary>
        /// <para>Creator coenraad: opens About.cs and closes MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.MdiParent = this.ParentForm;
            About.Show();
            Close();
        }
        /// <summary>Method Loadbtn_Click</summary>
        /// <para>Creator Johnny: opens MainGame.cs with Variables.loadgame = 1 and closes MainMenu.cs</para>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loadbtn_Click(object sender, EventArgs e)  //the load funtion to load in the Previous game.
        {
            MainGame MainGame = new MainGame();
            Variables.loadgame = 1;
            MainGame.MdiParent = this.ParentForm;
            MainGame.Show();
            Close();
        }
        /// <summary>Method Loadhighscore</summary>
        /// <para>Creator Richard: Checks for a highscores.sav and loads it in.</para>
        private void loadhighscore()
        {
            if (File.Exists("highscores.sav"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("highscores.sav");
                for (int i = 0; i < 5; i++)
                {
                    for (int e = 0; e < 10; e++)
                    {
                        Variables.highscoresscore[i, e] = Convert.ToInt32(doc.SelectSingleNode("highscores/highscoresscore" + i + e).InnerText);
                        Variables.highscoresplayer[i, e] = doc.SelectSingleNode("highscores/highscoresplayer" + i + e).InnerText;
                    }
                }
            }
        }
    }
}
