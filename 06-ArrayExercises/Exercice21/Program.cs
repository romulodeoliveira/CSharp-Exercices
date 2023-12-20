/*
Escreva um programa C# Sharp para a multiplicação de duas matrizes quadradas.
Dados de teste:
Insira as linhas e colunas da primeira matriz: 2 2
Insira as linhas e colunas da segunda matriz: 2 2
Insira os elementos da primeira matriz:
elemento - [0],[0] : 1
elemento - [0],[ 1] : 2
elementos - [1],[0] : 3
elementos - [1],[1] : 4
elementos de entrada na segunda matriz :
elemento - [0],[0] : 5
elementos - [0], [1] : 6
elemento - [1],[0] : 7
elemento - [1],[1] : 8
Saída esperada :
A primeira matriz é :

1 2
3 4
A segunda matriz é :

5 6
7 8
A multiplicação de duas matrizes é:

19 22
43 50
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira as linhas e colunas da primeira matriz (por exemplo, 2 2): ");
        string[] dimensoes1 = Console.ReadLine().Split();
        int linhas1 = Convert.ToInt32(dimensoes1[0]);
        int colunas1 = Convert.ToInt32(dimensoes1[1]);

        Console.Write("Insira as linhas e colunas da segunda matriz (por exemplo, 2 2): ");
        string[] dimensoes2 = Console.ReadLine().Split();
        int linhas2 = Convert.ToInt32(dimensoes2[0]);
        int colunas2 = Convert.ToInt32(dimensoes2[1]);

        if (colunas1 != linhas2)
        {
            Console.WriteLine("A multiplicação não é possível. O número de colunas da primeira matriz deve ser igual ao número de linhas da segunda matriz.");
            return;
        }

        int[,] matriz1 = PreencherMatriz("primeira", linhas1, colunas1);

        int[,] matriz2 = PreencherMatriz("segunda", linhas2, colunas2);

        int[,] resultado = MultiplicarMatrizes(matriz1, matriz2);

        Console.WriteLine("\nA primeira matriz é:\n");
        ExibirMatriz(matriz1);

        Console.WriteLine("\nA segunda matriz é:\n");
        ExibirMatriz(matriz2);

        Console.WriteLine("\nA multiplicação de duas matrizes é:\n");
        ExibirMatriz(resultado);
    }

    static int[,] PreencherMatriz(string nome, int linhas, int colunas)
    {
        Console.WriteLine($"\nElementos de entrada na {nome} matriz:");

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

    static int[,] MultiplicarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        int linhas1 = matriz1.GetLength(0);
        int colunas1 = matriz1.GetLength(1);
        int colunas2 = matriz2.GetLength(1);

        int[,] resultado = new int[linhas1, colunas2];

        for (int i = 0; i < linhas1; i++)
        {
            for (int j = 0; j < colunas2; j++)
            {
                for (int k = 0; k < colunas1; k++)
                {
                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                }
            }
        }

        return resultado;
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
