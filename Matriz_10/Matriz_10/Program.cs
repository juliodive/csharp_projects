using System;
using System.Globalization;

namespace Matriz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados para matriz
            int N = int.Parse(Console.ReadLine());
            //FIM
            double[,] matriz = new double[N, N];
            //Leitura de Valores
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
                }
            }
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            //FIM

            // Inicio de calculos de valores

            // Inicio Soma Matriz
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] > 0.0)
                    {
                        soma += matriz[i, j];
                    }
                }

            }
            Console.WriteLine(soma.ToString("f1",CultureInfo.InvariantCulture));
            // FIM SOMA

            // Inicio leitura de Indices

            // Linha
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == A)
                    {
                        Console.Write(matriz[i, j].ToString("f1",CultureInfo.InvariantCulture) + " ");
                    }

                }
                Console.WriteLine();
            }
            // Coluna
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == B)
                    {
                        Console.Write(matriz[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");
                    }

                }

            }
            Console.WriteLine();
            // Diagonal
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();
            // Matriz Alterada
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        matriz[i, j] = matriz[i, j] * matriz[i, j];
                    }
                    Console.Write(matriz[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
