/*
Escreva um programa C# Sharp para encontrar a soma de linhas e colunas em uma matriz.
Dados de teste:
Insira o tamanho da matriz quadrada: 2
Elementos de entrada na primeira matriz:
elemento - [0],[0] : 5
elemento - [0],[1] : 6
elemento - [1],[0] : 7
elemento - [1],[1] : 8
Saída esperada :
A primeira matriz é :
A matriz é :
5 6
7 8
A soma ou linhas e colunas da matriz é :
5 6 11
7 8 15

12 14
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

        int[] somaLinhas = SomaLinhas(matriz);
        int[] somaColunas = SomaColunas(matriz);

        Console.WriteLine("\nA soma das linhas da matriz é:");
        ExibirArray(somaLinhas);

        Console.WriteLine("\nA soma das colunas da matriz é:");
        ExibirArray(somaColunas);
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

    static int[] SomaLinhas(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        int[] somaLinhas = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                somaLinhas[i] += matriz[i, j];
            }
        }

        return somaLinhas;
    }

    static int[] SomaColunas(int[,] matriz)
    {
        int tamanho = matriz.GetLength(1);
        int[] somaColunas = new int[tamanho];

        for (int j = 0; j < tamanho; j++)
        {
            for (int i = 0; i < tamanho; i++)
            {
                somaColunas[j] += matriz[i, j];
            }
        }

        return somaColunas;
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

    static void ExibirArray(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
