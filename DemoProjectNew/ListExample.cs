using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class ListExample
    {
        static void Main()
        {
            //initialize the list  with string 
            List<string> fruits = new List<string>();

            //add elements in the list

            fruits.Add("Appple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Cherry");

            //printing all element in the list
            foreach(string fr  in fruits)
            {
                Console.WriteLine(fr);  
            }

            //print the specific element in the list
            Console.WriteLine("element:" + fruits[1]);

            //modify the element in the list

            fruits[1] = "Bananatest";
            fruits[2] = "mangotest";


            // remove element from list

            fruits.Remove ("Cherry");
            fruits.RemoveAt(2);

            //printing all element in the list after removalk
            foreach (string fr in fruits)
            {
                Console.WriteLine(fr);
            }

            //count the element in the list
            Console.WriteLine("Coount of element :"+fruits.Count);

            // insert element in to the list

            fruits.Insert(2, "mango");
            fruits.Insert(4, "Cherry");

            //printing all element in the list after insert
            foreach (string fr in fruits)
            {
                Console.WriteLine(fr);
            }

            fruits.Clear();
            //count the element in the list
            Console.WriteLine("Coount of element :"+fruits.Count);

        }
    }
}
