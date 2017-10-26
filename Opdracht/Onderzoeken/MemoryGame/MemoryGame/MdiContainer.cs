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
    class Variables
    {
        public static string[] playernames = new string[4];
        public static int theme = 1, difficulty = 3, amountplayers = 1;
    }

    public partial class MdiContainer : Form
    {
        public MdiContainer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Icon = new System.Drawing.Icon("Memory Game Icon 48x48.ico");
            MainMenu form2 = new MainMenu();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            form2.MdiParent = this;
            form2.Show();
        }
    }
}
