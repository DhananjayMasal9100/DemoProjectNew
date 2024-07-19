using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{

    public class Animal2
    {
        public void Eat2()
        {
            Console.WriteLine("eatiing");

        }

    }
    public class Dog2 : Animal2
    {
        public void Bark2()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    public class Cat2 : Animal2
    {

        public void Meow()
        {
            Console.WriteLine("cat is meowing");
        }
    }
    internal class HirarchicalInheritance
    {
        static void Main()
        {
            Dog2 dg = new Dog2();
            dg.Bark2();
            dg.Eat2();
            
            
            Cat2 ct = new Cat2();
            ct.Meow();
            ct.Eat2();

        }
    }
}
