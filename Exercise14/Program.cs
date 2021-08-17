using Exercise14.Entities;
using Exercise14.Entities.Enum;
using System;
using System.Collections.Generic;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of Shapes: ");
            int qty = int.Parse(Console.ReadLine());
            for(int i = 1; i <= qty; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(type == 'r')
                {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(color, radius));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Shape areas: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.area().ToString("F2"));
            }
        }
    }
}
