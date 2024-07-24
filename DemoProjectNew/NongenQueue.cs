using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class NongenQueue
    {
        static void  Main()
        {
            Queue qu = new Queue();
            //FIFO - Fist in First Out
            //Enque is basically used to add element in to the queue

            qu.Enqueue("Sachin");
            qu.Enqueue(123654);
            qu.Enqueue(true);

            // Dequeue (remove) - to remove the element from the queue

            object firstelement = qu.Dequeue();
            object SecondElement = qu.Dequeue();
            object ThirdElement = qu.Dequeue();

            //Display the items dequeueed

            Console.WriteLine("Dequeued Elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(SecondElement);
            Console.WriteLine(ThirdElement);

        }
    }
}
