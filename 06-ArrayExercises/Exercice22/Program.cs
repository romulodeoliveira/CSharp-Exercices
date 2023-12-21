/*
Escreva um programa C# Sharp para encontrar a transposição de uma determinada matriz.
Dados de teste:
Insira as linhas e colunas da matriz: 2 2
Insira os elementos na primeira matriz:
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [1],[ 0] : 3
elemento - [1],[1] : 4
Saída esperada :
A matriz é :

1 2
3 4

A transposição de uma matriz é :
1 3
2 4
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira as linhas e colunas da matriz (por exemplo, 2 2): ");
        string[] dimensoes = Console.ReadLine().Split();
        int linhas = Convert.ToInt32(dimensoes[0]);
        int colunas = Convert.ToInt32(dimensoes[1]);

        int[,] matriz = PreencherMatriz(linhas, colunas);

        Console.WriteLine("\nA matriz é :\n");
        ExibirMatriz(matriz);

        int[,] transposta = TransporMatriz(matriz);

        Console.WriteLine("\nA transposição de uma matriz é :\n");
        ExibirMatriz(transposta);
    }

    static int[,] PreencherMatriz(int linhas, int colunas)
    {
        Console.WriteLine("\nElementos na matriz:");

        int[,] matriz = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"elemento - [{i}],[{j}] : ");
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        return matriz;
    }

    static int[,] TransporMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        int[,] transposta = new int[colunas, linhas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                transposta[j, i] = matriz[i, j];
            }
        }

        return transposta;
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
