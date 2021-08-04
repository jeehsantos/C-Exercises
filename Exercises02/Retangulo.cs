using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises02
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2) + (Math.Pow(Altura, 2))));
        }

        public override string ToString()
        {
            return "Area ="
                    + Area().ToString("F2")
                    + "Perimetro ="
                    + Perimetro().ToString("F2")
                    + "Diagonal ="
                    + Diagonal().ToString("F2");
        }
    }
}
