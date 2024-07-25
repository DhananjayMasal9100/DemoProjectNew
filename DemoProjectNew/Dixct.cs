using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class Dixct
    {

        static void Main()
        {
            //initialize dictionary
            Dictionary<string,int> agedict = new Dictionary<string,int>();

            //add Key-Value pains to the dictinoary

            agedict.Add("Rohit", 27);
            agedict.Add("Sangram", 24);
            agedict.Add("Sachin", 25);
            
            //print all the elements in the dictoinry
            Console.WriteLine("All elements in the Dictionary");
            foreach(KeyValuePair<string,int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }

            //print specific Items from the dictinorary
            Console.WriteLine("Age of 'Rohit': "+ agedict["Rohit"] );
            Console.WriteLine("Age of 'Sangram': "+ agedict["Sangram"]);

            //Modify the values form dictionary

            agedict["Rohit"] = 29;
            agedict["Sachin"] = 22;


            //Print all modified values from dictionary
            Console.WriteLine("All elements in the Dictionary");
            foreach (KeyValuePair<string, int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }


            //remove value
            agedict.Remove("Sachin");



            if(agedict.ContainsKey("Rohit"))
            {
                Console.WriteLine("Exist in the dictionary");
            }


            //to clear the disctionary

            agedict.Clear();


            Console.WriteLine(agedict.Count);

        }
    }
}
