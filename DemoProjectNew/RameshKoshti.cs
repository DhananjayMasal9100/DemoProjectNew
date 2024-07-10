using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    public class Person
    {
        string pname;
        int page;
        public string Name
        {
            get {  return pname; }  
            set { pname = value; }
        }

        public int Age
        {
            get; set;
        }
        public void paddress()
        {
            Console.WriteLine("paddress");
        }
    }

    class RameshKoshti
    {
        static void Main()
        {
            Person person = new Person();
            person.Name = "Ramesh";
            Console.WriteLine(person.Name);
            person.Age = 29;
            Console.WriteLine(person.Age);
            person.paddress();
            Console.WriteLine("\n\nIts End");
        }
    }
}
