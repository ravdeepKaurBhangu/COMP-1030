using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* int[] rollno = new int[8];
             rollno[0] = 17001;
             rollno[1] = 17002;
             rollno[2] = 17003;
             rollno[3] = 17004;
             rollno[4] = 17005;
             rollno[5] = 17006;
             rollno[6] = 17007;
             rollno[7] = 17008;
             label1.Text = "";
             for(int i=0;i<8;i++)
               label1.Text= label1.Text+"\n"+rollno[i].ToString();*/

            /* const int size = 8;
             int[] rollno = new int[size] {17001,17002,17003,17004,17005,17006,17007,17008 };
             */

            /*  String[] names = new String[3] {"Aditya","is","music-director", };
              label1.Text = "";
            /*  for (int i = 0; i <names.Length; i++)
                  label1.Text = label1.Text + " " + names[i];*/
            /*
                        foreach(String i in names)
                        {
                            label1.Text=label1.Text+" "+i ;
                        }*/



            ///File Processing
            /// 
            /*    String[] names = new String[3] { "Aditya", "is", "good boy", };

                StreamWriter output;
                output = File.CreateText("IMDW.txt");

                foreach(String val in names)
                {
                    output.WriteLine(val);
                }
                output.Close();
                MessageBox.Show("Data written in file");

               */
            int[] num = new int[3];
            StreamReader input;
            input = File.OpenText("myfile.txt");

            for(int i=0;i<num.Length && !input.EndOfStream ;i++)
            {
                num[i] = int.Parse(input.ReadLine());
            }
            foreach(int x in num)
            {
                label1.Text = label1.Text + " " + x;
            }
        }
    }
}
