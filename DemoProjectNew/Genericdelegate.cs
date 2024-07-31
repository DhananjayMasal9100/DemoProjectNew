using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    

    internal class Genericdelegate
    {
        //Func
        public static double AddNumbers1(int a, float b, double c)
        {
            return a + b + c;
        }
        //Action
        public static void AddNumbers2(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        //Predicate
        public static bool checklength(string str) 
        {
           if (str.Length >5 )
                 return true;
           return false;
        }

       static void Main()
        {
            //Func Delegate
            Func<int, float, double, double> obj1 = AddNumbers1;
            double result = obj1.Invoke(100, 125f, 256.23);
            Console.WriteLine(result);

            //Action

            Action<int,float,double> obj2 = AddNumbers2;
            obj2.Invoke(200, 125f, 265.23);

            //Predicate

            Predicate<string> obj3 = checklength;
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status);


        }
    }
}
