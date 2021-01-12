using System;

namespace Matriz_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados da matriz
            int N = int.Parse(Console.ReadLine());
            //Fim
            int[,] matrix = new int[N, N];
            //Entrada de valores
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }
            //FIM
            int soma = 0;
            // Leitura de dados e Saida
            for (int i = 0; i < N; i++)
            {
                soma += matrix[i, i];
            }
            Console.WriteLine(soma);
            //FIM
        }
    }
}
