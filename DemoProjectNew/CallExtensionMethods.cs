using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class CallExtensionMethods
    {

        static void Main(string[] args)
        {
            ExtensionMethodsold ext = new ExtensionMethodsold();
            ext.Test1();
            ext.Test2();

            //extension Method calling

            ext.Test3();
            ext.Test4(10);
            ext.Test5();
         

        }


    }
}
