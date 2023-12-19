/*
Escreva um programa C# Sharp para adicionar duas matrizes do mesmo tamanho.
Dados de teste:
Insira o tamanho da matriz quadrada (menor que 5): 2
Elementos de entrada na primeira matriz:
elemento - [0],[0] : 1
elemento - [0],[1] : 2
elemento - [1 ],[0] : 3
elementos - [1],[1] : 4
elementos de entrada na segunda matriz :
elemento - [0],[0] : 5
elementos - [0],[1] : 6
elementos - [ 1],[0]: 7
elemento - [1],[1]: 8
Saída esperada :
A primeira matriz é:

1 2
3 4
A segunda matriz é:

5 6
7 8
A adição de duas matrizes é:

6 8
10 12
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz quadrada (menor que 5): ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[,] matriz1 = PreencherMatriz("primeira", tamanho);

        int[,] matriz2 = PreencherMatriz("segunda", tamanho);

        int[,] resultado = AdicionarMatrizes(matriz1, matriz2);

        Console.WriteLine("\nA primeira matriz é:\n");
        ExibirMatriz(matriz1);

        Console.WriteLine("\nA segunda matriz é:\n");
        ExibirMatriz(matriz2);

        Console.WriteLine("\nA adição de duas matrizes é:\n");
        ExibirMatriz(resultado);
    }

    static int[,] PreencherMatriz(string nome, int tamanho)
    {
        Console.WriteLine($"\nElementos de entrada na {nome} matriz:");

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

    static int[,] AdicionarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int tamanho = matriz1.GetLength(0);
        int[,] resultado = new int[tamanho, tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static void ExibirMatriz(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
