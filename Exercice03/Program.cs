using System;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salario Bruto $ ");
            func1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Salario Imposto $ ");
            func1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: {0}, $ {1}", func1.Nome, func1.SalarioLiquido());

            Console.WriteLine("Digite uma porcentagem para aumentar o salario");
            func1.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados Atualizados: " + func1);

        }
    }
}
