using System;

namespace Matriz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados da Matriz
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            //FIM
            int[,] matrix = new int[M, N];
            int[,] B = new int[M, N];
            //Leitura de valores
            for (int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                    B[i, j] = matrix[i, j];
                }
            }
            int val = int.Parse(Console.ReadLine());
            int fila = val - 1;
            
            //FIM DA LEITURA
            int count = 1;
            for (int i = 0; i < M; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    if (fila == i)
                    {
                        
                        int A = N - count;
                        
                        if(count != N)
                        {
                           
                            matrix[i, j] = matrix[i, A];
                        }
                        else
                        {
                            
                            matrix[i, j] = B[i, 0];
                        }
                        
                        count++;
                        
                    }
                    Console.Write(matrix[i, j] + " ");
                    
                }
                Console.WriteLine();

            }
        }
    }
}
