using System;
using System.Globalization;

namespace Exerc_Encapsulamento {
    class Program {
        static void Main(string[] args) {

            ContaBancaria cb;

            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Nome do Titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Deseja realizar um deposito inicial? ");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 'S' || resp == 's') {
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 cb = new ContaBancaria(conta, nome, saldo);
            }
            else {
                cb = new ContaBancaria(conta, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(cb);

            Console.WriteLine();
            Console.Write("Entre com um valor para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(cb);




        }
    }
}
