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
    public partial class Endscreen : Form
    {
        public Endscreen()
        {
            InitializeComponent();
        }

        private void Endscreen_Load(object sender, EventArgs e)
        {
            

        }



        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.MdiParent = this.ParentForm;
            MainMenu.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highscores Highscores = new Highscores();
            Highscores.MdiParent = this.ParentForm;
            Highscores.Show();
            Close();
        }

       
    }
}
