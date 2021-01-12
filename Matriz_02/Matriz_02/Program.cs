﻿using System;

namespace Matriz_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] entrada = Console.ReadLine().Split(' ');
            M = int.Parse(entrada[0]);
            N = int.Parse(entrada[1]);

            int[,] matrix = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for(int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(valores[j]);
                }
            }
            for(int i =0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
