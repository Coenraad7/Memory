using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            form4.MdiParent = this.ParentForm;
            form4.FormClosed += Form4_FormClosed;
            form4.Show();

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form4 = null;
            // throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            form5.MdiParent = this.ParentForm;
            form5.FormClosed += Form5_FormClosed1;
            form5.Show();

        }

        private void Form5_FormClosed1(object sender, FormClosedEventArgs e)
        {
            form5 = null;
            //throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            form6.MdiParent = this.ParentForm;
            form6.FormClosed += Form6_FormClosed;
            form6.Show();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            form6 = null;
            //throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
