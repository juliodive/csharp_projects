using System;
using System.Globalization;

namespace Exer02_class
{
    class Program
    {
        static void Main(string[] args)
        {
            funcionarios a, b;
            a = new funcionarios();
            b = new funcionarios();

            Console.WriteLine("Dados do primeiro Funcionário:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo Funcionário:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (a.Salario + b.Salario) / 2;
            Console.WriteLine("Salário médio:" + media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
