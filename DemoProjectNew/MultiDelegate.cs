using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public delegate void Notify();

    class Mdelegate
    {
        public void StartProcess()
        {
            Console.WriteLine("Process Started.....!");
        }
        public void StopProcess()
        {
            Console.WriteLine("Process Ended...!");
        }
    }

    internal class MultiDelegate
    {
        static void Main()
        {
            Mdelegate MD = new Mdelegate();

            //Create the delegate instance and assign the startprocrss method
            Notify notifydelegates = MD.StartProcess;

            //add endprocess method 
            notifydelegates += MD.StopProcess;
            //notifydelegates =notifydelegates+MD.StartProcess;

            //display anonymous method/message
            notifydelegates +=() => Console.WriteLine("All Processes are Stoped");

            //Need to Invoke the Multicat delegate

            notifydelegates();

        }


    }
}
