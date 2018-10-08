using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String n1 = textBox1.Text;
                double number = double.Parse(n1);

                /*    if(number%2==0)
                    {
                        MessageBox.Show("Number is even");
                    }
                    else
                    {
                        MessageBox.Show("Number is odd");
                    }*/

                if (number >= 60 && number <= 70)
                {
                    label2.Text = "C grade";
                }
                else if (number > 70 && number <= 80)
                {
                    label2.Text = "B grade";
                }
                else if (number > 80 && number <= 90)
                {
                    label2.Text = "A grade";
                }
                else if (number > 90 && number <= 100)
                {
                    label2.Text = "A+ grade";
                }
                else
                {
                    label2.Text = "F grade";
                }
                MessageBox.Show("Thank you");
            }
            catch(Exception obj)
            {
                label2.Text = "Please enter a number only";
            }
            
        }
    }
}
