using Exercise23.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise23
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category category1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category category2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category category3 = new Category() { Id = 3, Name = "Eletronics", Tier = 3 };

            List<Products> products = new List<Products>
            {
                new Products { Id = 1, Name = "Computer", Price = 1100.00, Category = category2},
                new Products { Id = 2, Name = "Mobile", Price = 1100.00, Category = category3},
                new Products { Id = 3, Name = "Mouse", Price = 1100.00, Category = category2},
                new Products { Id = 4, Name = "Monitor", Price = 1100.00, Category = category3},
                new Products { Id = 5, Name = "Hammer", Price = 1100.00, Category = category1},
                new Products { Id = 6, Name = "Saw", Price = 1100.00, Category = category1},
                new Products { Id = 7, Name = "Sound Bar", Price = 1100.00, Category = category1},
                new Products { Id = 8, Name = "Ply sheet", Price = 1100.00, Category = category1},
                new Products { Id = 9, Name = "Printer", Price = 1100.00, Category = category2},
                new Products { Id = 10, Name = "Camera", Price = 1100.00, Category = category3}

            };

            var r1 = products.Where(p => p.Id == 6);
            Print("Product with code 6", r1);


            var r2 = products.OrderBy(p => p.Name);
            Print("Product ordered by name", r2);

            var r3 = products.Where(p => p.Category.Tier != 1).Select(p => new { p.Name, p.Price });
            Print("Category different from Computers", r3); 
        }
    }
}
