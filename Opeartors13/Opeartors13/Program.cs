using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opeartors13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1=10;
            int number2;
            //  number1 = number1-20;
            // number1 *= 5;
            // ++number1;
            //  number1 = ++number1;
            // number1 = number1++;
            // Console.WriteLine(number1);
            //number2 = number1++;   //Assign then inc
            number2 = ++number1;     //Inc then assign
          //Console.WriteLine(number2);
           // Console.WriteLine(number1);

            int marks1, marks2;
            marks1 = 55;
            marks2 = 55;
            bool result;
            //result = marks1 > marks2;
            // Console.WriteLine(marks1>marks2);
            //result = marks1 < marks2;
            //result = marks1 < marks2;
            //  result = marks1 <= marks2;
          //  result = marks1==marks2;
            result = marks1!=marks2;
            // Console.WriteLine(result);

            int a = 9, b = 8, c = 4, d = 1;
            bool res1, res2,res3,res4;
            res1 = a > b;
            // res2 = c >= d;
            // res3 = res1 || res2;
            res2 = c <= d;
            ///  res3 = res1 || res2;
            res3 = res1 && res2;
            res4 = res2 != res3;
            Console.WriteLine(res4);

        }
    }
}
