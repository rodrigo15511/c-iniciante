﻿﻿using System;

namespace Aula_7
{
    class Program
    {

        static void Teste ()
        {
            // Matriz Tridimencional
            // Na tridiciomensional, 3 indices
            // 1º indice: Linha
            // 2º indice: Coluna
            // 3º indice: Profundidade

            int[,,] matriz3D = new int[2, 2, 2] {
                {
                    {1, 2},
                    {3, 4}
                },
                {
                    {5, 6},
                    {7, 8}
                }
            };

            // Percorrendo a matriz
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
                    }
                }
            }
            int soma = 0;
            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                       soma += matriz3D[i, j, k]; 
                    }
                }
            }
            System.Console.WriteLine($"A soma eh {soma}");

            // Acessar todos os elemtentos da matrizTri com Foreach
            foreach (int item in matriz3D)
            {
                System.Console.WriteLine(item);
            }
        }        
    }
}  
