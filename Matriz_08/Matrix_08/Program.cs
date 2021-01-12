using System;

namespace Matrix_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            //Entrada de dados para geração da matriz
            string[] entrada = Console.ReadLine().Split(' ');
            M = int.Parse(entrada[0]);
            N = int.Parse(entrada[1]);
            //FIM
            int[,] mat_01 = new int[M, N];
            int[,] mat_02 = new int[M, N];
            // Entrada de valores Matriz 01
            for (int i = 0; i < M; i++)
            {
                string[] val_01 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat_01[i, j] = int.Parse(val_01[j]);
                }
            }
            // Entrada de valores Matriz 02
            for (int i = 0; i < M; i++)
            {
                string[] val_02 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat_02[i, j] = int.Parse(val_02[j]);
                }
            }
            //FIM DAS ENTRADAS
            int[,] mat_03 = new int[M, N];
            // Inicio de Calculos de dados
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    mat_03[i, j] = mat_01[i, j] + mat_02[i, j];
                    Console.Write(mat_03[i, j] + " ");
                }
                Console.WriteLine();
            }
            // FIM
        }
    }
}
