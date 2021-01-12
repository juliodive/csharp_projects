using System;

namespace Matrix_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            // Entrada de dados para Matriz
            string[] entrada = Console.ReadLine().Split(' ');
            M = int.Parse(entrada[0]);
            N = int.Parse(entrada[1]);
            // Fim

            int[,] matrix = new int[M, N];
            
            // Entrada de Valores
            for(int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }
            // Fim

            int[] vet = new int[M];

            // Inicio da sainda
            for (int i = 0; i < M; i++)
            {
                int soma = 0;
                for(int j =0; j < N; j++)
                {
                    soma += matrix[i, j];
                }
                vet[i] = soma;
                Console.WriteLine(vet[i]);
            } 
            // Fim
        }
    }
}
