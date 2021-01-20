using System;
using System.Globalization;

namespace CotacaoDoDolar {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar? ");
            double cot_dol = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quant_dol = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = ConversorDeMoeda.Cotacao(quant_dol, cot_dol);
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
