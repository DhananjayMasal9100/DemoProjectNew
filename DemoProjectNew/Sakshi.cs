using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class Sakshi
    {

         static void Main()
        {
            Console.WriteLine("Hello");
        }
        
    class ReverseString
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Given Name is CODEMIND TECHNOLOGY !!!");
            string name = "CODEMIND TECHNOLOGY !!!";
            string result = " ";
            for (int i = name.Length - 1; i > -1; i--)
            {
                char getSingleChar = name[i];
                result += getSingleChar;
            }
            Console.WriteLine("Reverse is " + result);
        }


    }
    }

}
