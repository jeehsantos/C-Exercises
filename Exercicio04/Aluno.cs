using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        private double media;

        public void SumPontos()
        {
          media = N1 + N2 + N3 ;
           
        }

        public void CheckAprovado()
        {
            SumPontos();
            if(media > 60.00) {  
                Console.WriteLine("NOTA FINAL = "+ media.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Aprovado");
            }
            else
            {
                double check =  60.00 - media ;
                Console.WriteLine("NOTA FINAL = " + media.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram {0} pontos", check.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}
