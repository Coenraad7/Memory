﻿using System;
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
        public MainMenu()
        {
            InitializeComponent();
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
    }
}
