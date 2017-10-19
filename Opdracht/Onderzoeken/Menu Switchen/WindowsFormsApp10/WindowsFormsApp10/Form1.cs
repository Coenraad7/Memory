using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // hiermee gaat de form weg als het volgende form tevoorschijnkomt. dit voorkomt stacking van de Windows Forms.
            var newwindow = new Form2(); // var is handig als je een variable wilt koppelen aan een object.

            newwindow.Show(); // Hiermee laat Form2 zien als ik op de Button Play klik

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newwindow = new Form3();

            newwindow.Show();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newwindow = new Form4();

            newwindow.Show();
        }
    }
}
