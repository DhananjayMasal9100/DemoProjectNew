using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    //abstract class
    public abstract class Animal
    {
        //abstract method -
        public abstract void Makesound();

        //non abstract method
        public void Eat()
        {
            Console.WriteLine("Animal");
        }

    }

    //Derived class 1

    public class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Dog");
        }

    }


    //Derived class 2

    public class Cat : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("Cat");
        }
    }


    internal class AbstractCls
    {
        static void Main()
        {

            //object creation for the derived class

            Dog dog = new Dog();
            Cat cat = new Cat();

            // call the method
            dog.Makesound();
            dog.Eat();


            cat.Makesound();
            cat.Eat();





        }



    }
}
