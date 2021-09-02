using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> file = new List<Product>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        file.Add(new Product() { Name = line[0], Price = double.Parse(line[1]) });
                    }
                }
                var average = file.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                var r1 = file.Where(p => p.Price <= average).OrderByDescending(p => p.Name).Select(p => p.Name);

                Console.WriteLine("Average price: " + average.ToString("F2"));
                foreach (string p in r1)
                {
                    Console.WriteLine(p);
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
        }
    }
}
