using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class Hashtble
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();

            //  Add key-value pairs to the hashtable
            ht.Add(101, "JAVA");
            ht.Add(102, "DOTNET");
            ht.Add(103, 9890);
            ht.Add(104, true);
                        
            //Access the element , although typecasting is required.

            string value1 = (string)ht[101];
            string value2 = (string)ht[102];
            string value3 = Convert.ToString((int)ht[103]);
            bool value4 = (bool)ht[104];

            //Display the values
            Console.WriteLine($"101:{value1}");
            Console.WriteLine($"102:{value2}");
            Console.WriteLine($"103:{value3}");
            Console.WriteLine($"104:{value4}");

        }
    }
}
