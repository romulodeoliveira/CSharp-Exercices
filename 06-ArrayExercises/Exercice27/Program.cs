/*
Escreva um programa C# Sharp para imprimir ou exibir uma matriz triangular superior.
Dados de teste :
Insira o tamanho da matriz quadrada : 3
elementos de entrada na primeira matriz :
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [0],[2] : 3
elementos - [1],[0] : 4
elementos - [1],[1] : 5
elementos - [1],[2] : 6
elementos - [2],[0] : 7
elementos - [2 ],[1] : 8
elemento - [2],[2] : 9
Saída esperada :
A matriz é :
1 2 3
4 5 6
7 8 9

Definindo zero na matriz triangular superior

1 0 0
4 5 0
7 8 9
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

        Console.WriteLine("\nDefinindo zero na matriz triangular superior:\n");
        ImprimirTriangularSuperior(matriz);
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

    static void ImprimirTriangularSuperior(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                if (j >= i)
                    Console.Write(matriz[i, j] + " ");
                else
                    Console.Write("0 ");
            }
            Console.WriteLine();
        }
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
