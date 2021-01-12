using System;

namespace Matriz_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL:");

            for (int i = 0; i < N; i++)
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total de numeros negativos: " + count);
        }
    }
}





