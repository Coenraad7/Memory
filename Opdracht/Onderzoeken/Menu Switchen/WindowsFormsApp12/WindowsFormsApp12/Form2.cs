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
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        public Form2()
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
    }
}
