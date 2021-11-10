//3.Store a product information in map object.
//Key will be a product item and value will be the price of that product.
//Search the product by product name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Excercise3
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> products = new Dictionary<string, float>();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter product name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                float productPrice = Convert.ToSingle(Console.ReadLine());
                products.Add(productName,productPrice);
            }

            Console.WriteLine("Search by product name:");
            string searchquery = Console.ReadLine();
            if (products.ContainsKey(searchquery))
            {
                Console.WriteLine($"Price of {searchquery} is {products[searchquery]}");
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
            Console.ReadKey();
        }
    }
}
