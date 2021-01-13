using System;

namespace Exer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;
            a = new Pessoas();
            b = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }



        }
    }
}
