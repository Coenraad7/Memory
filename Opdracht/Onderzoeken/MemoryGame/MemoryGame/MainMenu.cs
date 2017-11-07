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
using System.Xml.Linq;
using System.Xml.XmlConfiguration;

namespace MemoryGame
{

    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            loadhighscore();
            if (!(File.Exists("memory_save.xml")))
            {
                Loadbtn.Visible = false;
            }
        }

        //coen
        private void button1_Click(object sender, EventArgs e)
        {
            Players form3 = new Players();
            form3.MdiParent = this.ParentForm;
            form3.Show();
            Close();
        }
        //coen
        private void button2_Click(object sender, EventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.MdiParent = this.ParentForm;
            Highscores.Show();
            Close();
        }
        //coen
        private void button4_Click(object sender, EventArgs e)
        {
            Help Help = new Help();
            Help.MdiParent = this.ParentForm;
            Help.Show();
            Close();
        }
        //coen
        private void button5_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.MdiParent = this.ParentForm;
            About.Show();
            Close();
        }

        private void Loadbtn_Click(object sender, EventArgs e)  //the load funtion to load in the Previous game.
        {
            MainGame MainGame = new MainGame();
            Variables.loadgame = 1;
            MainGame.MdiParent = this.ParentForm;
            MainGame.Show();
            Close();
        }
    
        private void loadhighscore()
        {
            if (File.Exists("highscores.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("highscores.xml");
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
