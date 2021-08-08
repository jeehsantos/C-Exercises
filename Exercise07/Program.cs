using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Console.Write("Do you wanna include a new product  (s/n) ? ");
            char answer = char.Parse(Console.ReadLine());
            while (answer == 's' || answer == 'S')
            {
                Console.WriteLine("Insert the following infos: ");
                Console.WriteLine();
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());
                product.Add(new Product(id, brand, desc, qty));

                Console.Write("Do you wanna include a new product  (s/n) ? ");
                answer = char.Parse(Console.ReadLine());
            }
            if (answer == 'n' || answer == 'N')
            {
                Console.WriteLine();
                Console.WriteLine("Current products: ");
                int qty = product.Count();
                Console.WriteLine("Total of products: " + qty);

                if (qty > 0)
                {
                    foreach (Product obj in product)
                    {
                        Console.WriteLine(obj);
                    }
                }
                else
                {
                    Console.WriteLine("You do not have any product registered !");
                }
            }

            Console.WriteLine("Type an product ID: ");
            int idSearch = int.Parse(Console.ReadLine());
            Product search = product.Find(x => x.Id == idSearch);
            Console.WriteLine(search);
        }
    }
}
