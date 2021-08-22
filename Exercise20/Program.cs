using System;
using System.Collections.Generic;

namespace Exercise20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();
           
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] product =  Console.ReadLine().Split(',');
                lista.Add(new Product(product[0], double.Parse(product[1])));
            }

            CalculationService newCalc = new CalculationService();
            Product max = newCalc.Max(lista);

            Console.WriteLine("Most expensive: ");
            Console.WriteLine(max);
        }
    }
}
