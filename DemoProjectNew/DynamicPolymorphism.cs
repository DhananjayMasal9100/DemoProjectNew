using DemoProjectNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    //Base Class
    //Method name same parameer also same but different class
    class Shape
    {

        //virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");

        }
    }

    //Derved class 
    class Circle : Shape
    {
        public override void Draw()
        {

            Console.WriteLine("drawwing circle");

        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }



    internal class DynamicPolymorphism
    {
        static void Main()
        {
            //creating object


            Shape shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();

            //calling method from each object
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();


        }
    }
}

