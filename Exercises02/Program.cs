using System;
using System.Globalization;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
           
            Console.WriteLine("Entre com a largura e altura do retangulo");
            r1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r1);

        }
    }
}
