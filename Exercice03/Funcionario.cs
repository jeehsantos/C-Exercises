using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {   double NovoSalario = SalarioBruto * (porcentagem / 100);
            SalarioBruto +=  NovoSalario;
        }

        public override string ToString()
        {
            return "Nome: "
                    + Nome
                    + "Salario $ "
                    + SalarioLiquido().ToString("F2");
        }
    }
}
