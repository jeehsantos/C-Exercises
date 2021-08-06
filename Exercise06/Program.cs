using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented ?");
            int rooms = int.Parse(Console.ReadLine());

            Product[] vec = new Product[9];

            for (int n = 1; n <= rooms; n++)
            {
                Console.WriteLine("Rent #{0}:", n);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vec[room] = new Product { Name = name, Email = email };

            }

           Console.WriteLine("Busy rooms: ");
            for(int i = 0; i < 9; i++)
            {
                if (vec[i] != null) {  
                Console.WriteLine("{0}: {1}, {2}", i, vec[i].Name, vec[i].Email);
                }
            } 
        }
    }
}
