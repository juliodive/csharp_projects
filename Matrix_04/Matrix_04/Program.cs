using System;

namespace Matrix_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            // Dados para criação da Matriz
            string[] entrada = Console.ReadLine().Split(' ');
            M = int.Parse(entrada[0]);
            N = int.Parse(entrada[1]);
            // Fim

            int[,] matrix = new int[M, N];

            // Entrada de valores
            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }
            // Fim
            Console.WriteLine("Valores Negativos:");
            for (int i = 0; i < M; i++)
            {
                for (int j =0; j < N; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }
        }
    }
}
