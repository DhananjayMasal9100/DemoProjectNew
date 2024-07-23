using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{
    internal class ExceptionHandling
    {

        static void Main()
        {
            int[] Numbers = { 1, 2, 3 };
            int index = 4;

            try
            {
                //login
                int value = Numbers[index];  // IndexOutOfBound 
                Console.WriteLine($"value at index {index} is : {value}");

            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Index is out of range.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occoured:{ex.Message}");
            }

            finally//
            {
                Console.WriteLine("This code always execute");
            }


            //divide by Zero 

            int num = 10;
            int deno = 0;
            double result = 0;

            try
            {
                result = num/deno;  //  attempting to divide by Zero
                Console.WriteLine($"Result of division :{ result}");

            }
             catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}.cannot be devide by zero.");
            }


            // custom exception
            try
            {
                Dataprocessing(null);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}.argument cannot be null.");
            }



        }
        static void Dataprocessing(string data)
        {
            if (data == null) 
            {
                throw new ArgumentNullException(nameof(data),"Data Cannot be null");            
            }
        }


    }
}
