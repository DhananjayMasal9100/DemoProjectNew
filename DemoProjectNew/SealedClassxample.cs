using DemoProjectNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public  class BaseClass
    {
        public virtual int add(int x, int y)
        {
            return x + y;
        }
    }

    public class DerivedClass : BaseClass
    {
        public sealed  override int add(int x, int y)
        {
            return x - y;
        }

    }
    internal class SealedClassxample
    {
        static void Main()

        {
            int a = 10;
            int b = 20;
            DerivedClass d = new DerivedClass();
            BaseClass B = new BaseClass();
            d.add(a, b);
            B.add(a, b);

        }
    }
}
