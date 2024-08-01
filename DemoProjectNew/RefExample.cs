using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class RefExample
    {
        public static void Swaping( ref int a, ref int b)
        {
            int temp = a;
            a= b;
            b= temp;

        }

        public static void Main()
        {
            int x = 10;
            int y = 20;
            
            Console.WriteLine($"Before Swaping :x = {x}, y ={y}");

            Swaping(ref  x, ref y); //Pass by reference using ref Keyword.
            Console.WriteLine($"After Swaping :x ={x}, y ={y}");
        }
    }
}
