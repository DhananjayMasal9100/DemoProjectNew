using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class NonGenStack
    {
        //LIFO- Last In First Out
        static void Main()
        {
            //create a non- generic stack 
            Stack st = new Stack();

            st.Push("Top");
            st.Push(42);
            st.Push(false);

            //Remove( POP) the element from stack
            object topelement = st.Pop();
            object secondelement = st.Pop();
            object thridelement = st.Pop();

            //Dispay the poped elements

            Console.WriteLine("Poped elements");
            Console.WriteLine(topelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thridelement);

            //check   if the stack is empty or it has a value

            Console.WriteLine("Is sthe stack empty?"+(st.Count ==0));


        }


    }
}
