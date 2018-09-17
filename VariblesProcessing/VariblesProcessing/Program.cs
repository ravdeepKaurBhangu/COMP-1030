using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariblesProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Processing Data");
            int marks1 = 70;  //Initialization of variable
            int marks2 = 60;
            int result;
            result = marks1 + marks2;
            Console.WriteLine(marks1);
            Console.WriteLine(marks2);
            //Console.WriteLine(result);
            Console.WriteLine("Addition of two numbers is "+result);
            /*this is a multiline comment
            i am giving description of comment
            in COMP 1030 class*/


            //character datatype
            char grade = 'A';
            int marks = 9;
            char markss = '9';

            //string datatype  
            //collection of characters
            //enclosed in " "

            string mydata = "I am learning COMP-1030";

            /*float datatype
            Used to process fractional values like 3.45
            f is used at the end of assignment
            */
            float percentage = 78.34f;

            /*double datatype
            used for fractional values*/

            double per = 78.45;

            /*long datatype
            Whole numbers
                    */
            long value = 78778787;

            double price1 = 890.56;
            double price2 = 5566.45;
            double totalPrice = price1 + price2;
            Console.Write("Total price is " + totalPrice);



        }
    }
}
