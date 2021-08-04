using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno");
            aluno.N1 = double.Parse(Console.ReadLine());
            aluno.N2 = double.Parse(Console.ReadLine());
            aluno.N3 = double.Parse(Console.ReadLine());

            aluno.CheckAprovado();

        }
    }
}
