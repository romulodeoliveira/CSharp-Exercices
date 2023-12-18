/*
Escreva um programa em C# Sharp para um array 2D de tamanho 3x3 e imprima a matriz.
Dados de teste :
Elementos de entrada na matriz :
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [0],[2] : 3
elemento - [1],[0 ] : 4
elementos - [1],[1] : 5
elementos - [1],[2] : 6
elementos - [2],[0] : 7
elementos - [2],[1] : 8
elementos - [ 2],[2] : 9
Saída esperada :
A matriz é :

1 2 3
4 5 6
7 8 9
*/

using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Insira os elementos na matriz:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"elemento - [{i}],[{j}] : ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nA matriz é:\n");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
