using System;
using System.Globalization;
namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: "+ p1);

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            p1.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: "+ p1);

            Console.WriteLine("Digite o numero de produtos a ser removido ao estoque: ");
            p1.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: " + p1);

        }



    }
}
