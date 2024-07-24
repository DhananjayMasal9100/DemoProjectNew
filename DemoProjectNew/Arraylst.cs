using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoProjectNew
{
    internal class Arraylst
    {
        static void Main()
        {
            //creting An Array List
            ArrayList lst = new ArrayList();  
            //add element in to the Arraylist

            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false);

            //Access the elements/items 
            Console.WriteLine("Arraylist Elements:");
            foreach(var item in lst)
            {
                Console.WriteLine(item);
            }

            //Removing element from arraylist

            lst.Remove(false);


            //Access the elements after removal

            Console.WriteLine("Arraylist Elements after removal:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

        }
    }
}
