using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class Outexample
    {

        static void Main()
        {
            //Declare varibles with out initilizating
            int result1, result2,result3, result4;
            int x = 25, y = 30;

            //call the method with out  peremters
            Calculate(x,y, out result1, out result2,out result3,out result4);



            // Display the results
            Console.WriteLine("Addition is  : "+ result1);
            Console.WriteLine("Substraction is : " + result2);
            Console.WriteLine("Multiplication is :" + result3);
            Console.WriteLine("Division is :" + result4);
          


        }
        static  void Calculate(int x,int y, out int Addition ,out int substraction, out int multiplication,out int division)
        {

            Addition  = x + y;
            substraction = y-x;
            multiplication  = x*y;
            division = x/y;


            ////Initialize the out parameter
            //a = 10;
            //b=20;
            //// calcultions

            //a +=5;
            //b +=5;

        }
    }
}
