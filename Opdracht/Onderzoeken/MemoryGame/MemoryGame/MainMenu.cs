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
    
    public partial class MainMenu : Form
    {
        Players form3 = new Players();
        Help Help = new Help();
        Highscores Highscores = new Highscores();
        About About = new About();
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.MdiParent = this.ParentForm;
            form3.FormClosed += Form3_FormClosed;
            form3.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form3 = null;
            // throw new NotImplementedException();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highscores.MdiParent = this.ParentForm;
            Highscores.FormClosed += Highscores_FormClosed;
            Highscores.Show();
        }

        private void Highscores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Highscores = null;
           // throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help.MdiParent = this.ParentForm;
            Help.FormClosed += Help_FormClosed;
            Help.Show();
        }

        private void Help_FormClosed(object sender, FormClosedEventArgs e)
        {
            Help = null;
           // throw new NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About.MdiParent = this.ParentForm;
            About.FormClosed += About_FormClosed;
            About.Show();
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            About = null;
            //throw new NotImplementedException();
        }
    }
}
