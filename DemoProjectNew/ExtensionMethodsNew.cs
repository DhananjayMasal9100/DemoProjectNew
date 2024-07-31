using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public static class ExtensionMethodsNew
    {

        public static void Test3(this ExtensionMethodsold O)
        {
            Console.WriteLine("Method Three");
        }

        public static void Test4(this ExtensionMethodsold O, int x)
        {
            Console.WriteLine("Method Four:"+x);
        }

        public static void Test5(this ExtensionMethodsold O)
        {
            Console.WriteLine("Method Five"+ O.x);
        }
    }
}
