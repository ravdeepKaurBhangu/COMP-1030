using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form12Sept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            fname = textBox1.Text;  //fetching the text
            lname = textBox2.Text;
            MessageBox.Show("Welcome "+fname+" "+lname);
        }
    }
}
