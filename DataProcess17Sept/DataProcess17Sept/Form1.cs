using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataProcess17Sept
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2,result; // declared two double var
            String n1, n2;   //declared two string var
            n1=textBox1.Text; //fetched the text from textBox 1
            n2 = textBox2.Text; //fetched the text from textBox2

            num1 = double.Parse(n1); //Converting String to double
            num2=double.Parse(n2);

            result=num2 - num1;    //Calculations
    
            MessageBox.Show("Subtraction is "+result); //displaying result

         //   MessageBox.Show(n1-n2);
        }
    }
}
