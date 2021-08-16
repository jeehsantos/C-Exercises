using Exercise13.Entities;
using System;
using System.Collections.Generic;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int products = int.Parse(Console.ReadLine());
            for(int i = 1; i <= products; i++)
            {
                Console.Write("Common, used, imported (c/u/i) ?");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price $ ");
                double price = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));
                }else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Price Tags:");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
        }
    }
}
