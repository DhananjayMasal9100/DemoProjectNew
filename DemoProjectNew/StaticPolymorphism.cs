using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    //Method overloading/static poly
    //   Method name same but  parameter different in same class
    class MathOpertions
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    internal class StaticPolymorphism
    {
        static void Main()
        {
            MathOpertions math = new MathOpertions();
            //call overloading method

            int sum1 = math.Add(2, 3);
            double sum2 = math.Add(6, 5);


            Console.WriteLine("Sum  of Integers:"+ sum1);
            Console.WriteLine("Sum of Doubles:"+ sum2);


        }

    }
}
