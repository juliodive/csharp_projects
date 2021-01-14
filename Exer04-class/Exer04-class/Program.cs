using System;
using System.Globalization;

namespace Exer04_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos  a ser adicionados ao estoque: ");
            int qto = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qto);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos  a ser removido ao estoque: ");
            qto = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qto);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
