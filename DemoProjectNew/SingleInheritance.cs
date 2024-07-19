using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{


   //Super class | Parent Class | Base CLass
    public class Animal1
    {
        public void Eat1()
        {
            Console.WriteLine("Animal is Eating");
        }

    }
    //Sub class | Child Class  | Derived CLass
    public class Dog1 : Animal1
    {
        public void Test()
        {
            Console.WriteLine("Test Successful");

        }
        
    }

    internal class SingleInheritance
    {
        static void Main()
        {
            Dog1 dg = new Dog1();
            dg.Test();
            dg.Eat1();
        
        }

    }
}
