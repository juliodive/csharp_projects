using System;
using System.Globalization;

namespace Exer06_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();

            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + fun);

            Console.WriteLine();
            Console.Write("Digite a porcetagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            fun.AumentarSalario(porcent);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + fun);
        }
    }
}
