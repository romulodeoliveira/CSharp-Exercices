/*
Escreva um programa C# Sharp para encontrar a soma das diagonais direitas de uma matriz.
Dados de teste :
Insira o tamanho da matriz quadrada : 2
elementos de entrada na primeira matriz :
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [1],[0] : 3
elemento - [1],[1] : 4
Saída esperada :
A matriz é :
1 2
3 4
Adição dos elementos diagonais corretos é :5
Elementos na matriz são:
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz quadrada: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[,] matriz = PreencherMatriz(tamanho);

        Console.WriteLine("\nA matriz é:\n");
        ExibirMatriz(matriz);

        int somaDiagonalDireita = SomaDiagonalDireita(matriz);

        Console.WriteLine($"\nAdição dos elementos diagonais corretos é: {somaDiagonalDireita}");
    }

    static int[,] PreencherMatriz(int tamanho)
    {
        Console.WriteLine($"\nElementos na matriz ({tamanho}x{tamanho}):");

        int[,] matriz = new int[tamanho, tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write($"elemento - [{i}],[{j}] : ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return matriz;
    }

    static int SomaDiagonalDireita(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        int soma = 0;

        for (int i = 0; i < tamanho; i++)
        {
            soma += matriz[i, i];
        }

        return soma;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
