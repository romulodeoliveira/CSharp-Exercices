/*
Escreva um programa C# Sharp para encontrar a soma das diagonais esquerdas de uma matriz.
Dados de teste:
Insira o tamanho da matriz quadrada: 2
elementos de entrada na primeira matriz:
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [1],[0] : 3
elemento - [1],[1] : 4
Saída esperada :
A matriz é :
1 2
3 4
A adição dos elementos da diagonal esquerda é :5
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz quadrada: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = new int[tamanho, tamanho];

        Console.WriteLine("Insira os elementos da matriz:");
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"elemento - [{i}],[{j}] : ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("A matriz é:");
        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }

        int somaDiagonalEsquerda = 0;
        for (int i = 0; i < tamanho; i++)
        {
            somaDiagonalEsquerda += matriz[i, i];
        }

        Console.WriteLine($"A adição dos elementos da diagonal esquerda é: {somaDiagonalEsquerda}");
    }
}
