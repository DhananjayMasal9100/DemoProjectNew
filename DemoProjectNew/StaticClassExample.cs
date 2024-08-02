using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectNew
{

    //sstatic class
    static class Product
    {
        //static Members     
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;

        //static Constructor 
        static Product()
        {
            ProductId = 1100;
            ProductName = "Test";
            ProductPrice = 1000;
        }
        //static methods

        public static void GetProdctDetails()
        {
            Console.WriteLine("Product id :{0}",ProductId);
            Console.WriteLine("Product Name :{0}",ProductName);
            Console.WriteLine("Product Price : {0} ",ProductPrice);

        }
       public static void GetDiscount()
        {
            int D_amount = ProductPrice /10;
            Console.WriteLine("Your Discount amount is :{0}", D_amount);
            Console.WriteLine("Total Amount of Product: {0}" ,(ProductPrice -D_amount));


        }
    }

   
    internal class StaticClassExample
    {
        static void Main()
        {
            //Product p = new Product();

            Product.GetProdctDetails();

            Product.GetDiscount();
            Console.ReadLine();

            

        }

    }
}
