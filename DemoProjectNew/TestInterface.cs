using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public interface Logger
    {
        void logMessage(string message);

    }

    public interface TestLogger
    {
        public void TestLogMessage(string address);
    }

    public class ConsoleLogger : Logger,TestLogger    //multiple inheritnace  implemented as c# dosenot support we can achive usign he interface.
    {
        public void logMessage(string message)
        {
            Console.WriteLine($"Logging the message:{message}");

        }
        public void TestLogMessage(string address)
        {
            Console.WriteLine($"Address is:{address}");
        }
    }


    class TestInterface
    {
        static void Main()
        {
            //creatig instance for the child class as we can not crete the instance for the interface.
            ConsoleLogger cl = new ConsoleLogger();
            cl.logMessage("Hello World!");

            cl.TestLogMessage("Pune");
        }

    }
}
