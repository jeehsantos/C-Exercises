using Exercise11.Entities;
using Exercise11.Entities.Enum;
using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client newClient = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order newOrder = new Order(DateTime.Now, status, newClient);
            Console.Write("How many items to this order ? ");
            int orderItem = int.Parse(Console.ReadLine());
            for (int i = 1; i <= orderItem; i++ )
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine());
                Product newProd = new Product(prodName, prodPrice);
                Console.Write("Quantity: ");
                int prodQty = int.Parse(Console.ReadLine());
                OrderItem newItem = new OrderItem(prodQty, prodPrice, newProd);
                newOrder.addItem(newItem);
            }

            Console.WriteLine("Order Summary: ");
            Console.WriteLine(newOrder.ToString());
            
        }
    }
}
