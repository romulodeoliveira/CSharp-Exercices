using System;

/*
Escreva um programa C# Sharp para criar uma matriz identidade.

Dados de amostra:
Insira um número: 3
1 0 0
0 1 0
0 0 1
*/

namespace Exercice102;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = 0;
            }
        }

        for (int i = 0; i < n; i++)
        {
            matriz[i, i] = 1;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
