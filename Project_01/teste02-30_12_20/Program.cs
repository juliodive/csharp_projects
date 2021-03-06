﻿using System;
using System.Globalization;

namespace teste02_30_12_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            double[] preco_compra = new double[N];
            double[] preco_venda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nome[i] = valores[0];
                preco_compra[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                preco_venda[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }
            int count_abaixode10 = 0, count_10e20 = 0, count_acima20 = 0;
            double soma_compra = 0, soma_venda = 0, lucro, lucro_total = 0;

            for (int i = 0; i < N; i++)
            {
                double l;
                l = lucroA(preco_venda[i], preco_compra[i]);
                if (lucro < 10)
                {
                    count_abaixode10++;
                }
                if (lucro >= 10 && lucro <= 20)
                {
                    count_10e20++;
                }
                if(lucro > 20)
                {
                    count_acima20++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                soma_compra += preco_compra[i];
                soma_venda += preco_venda[i];
                lucro_total = soma_venda - soma_compra;
            }
            Console.WriteLine("Lucro menor que 10%: " + count_abaixode10);
            Console.WriteLine("Lucro entre 10% e 20%: " + count_10e20);
            Console.WriteLine("Lucro maior que 20%: " + count_acima20);
            Console.WriteLine("Valor total de compra: " + soma_compra.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + soma_venda.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro Total: " + lucro_total.ToString("f2", CultureInfo.InvariantCulture));
        }
        static double lucroA(double p1, double p2)
        {
            return ((p1 - p2) * 100) / p2;
        }
    }
    
}


