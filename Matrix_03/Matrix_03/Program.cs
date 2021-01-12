using System;


namespace Matrix_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            // Entrada de Matrix
            string[] entrada = Console.ReadLine().Split(' ');
            M = int.Parse(entrada[0]);
            N = int.Parse(entrada[1]);

            int[,] matrix = new int[M, N];

            // Entrada de valores
            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j =0;j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }

            int[] vet = new int[M];

            // Calculo da Matriz
            for(int i =0; i < M; i++)
            {  
                int soma = 0;

                for(int j =0;j < N; j++)
                {
                    soma += matrix[i, j];
                }
                vet[i] = soma;
            } 
            for(int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}
