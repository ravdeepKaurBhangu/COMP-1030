using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutPutFormattingExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal originalPrice;
            decimal discountPercentage;
            decimal discountAmount;
            decimal salePrice;
            try
            {
                originalPrice = decimal.Parse(textBox1.Text);
                discountPercentage = decimal.Parse(textBox2.Text);
                discountPercentage = discountPercentage / 100;
                discountAmount = originalPrice * discountPercentage;
                salePrice = originalPrice - discountAmount;

                textBox3.Text = salePrice.ToString("C3");

                //textBox3.Text = salePrice.ToString("c");
                // textBox3.Text = salePrice.ToString("n");
                // textBox3.Text = salePrice.ToString("e");
                //textBox3.Text = salePrice.ToString("f");

                // textBox3.Text = salePrice.ToString("p");


               // textBox3.Text = salePrice.ToString("d3");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("i am a exception");
            }

        }
    }
}
