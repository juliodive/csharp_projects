using System;

namespace Matriz_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            // Entrada de dados da matriz
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
            //Fim


            for (int i = 0; i < M; i++)
            {
                int maior = matrix[0, 0];
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > maior)
                    {
                        maior = matrix[i, j];
                    }
                }

                Console.WriteLine(maior);
            }
        }
    }
}
