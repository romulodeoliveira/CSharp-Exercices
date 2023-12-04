/*
Escreva um programa C# Sharp para copiar os elementos de um array para outro array.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 15
elemento - 1: 10
elemento - 2: 12
Saída esperada :
Os elementos armazenados na primeira matriz são:
15 10 12
Os elementos copiados no segundo array são:
15 10 12
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de elementos a serem armazenados na matriz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arrayOriginal = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento - {i}: ");
            arrayOriginal[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] arrayCopia = new int[n];

        for (int i = 0; i < n; i++)
        {
            arrayCopia[i] = arrayOriginal[i];
        }

        Console.WriteLine("Os elementos armazenados na primeira matriz são:");
        ExibirArray(arrayOriginal);

        Console.WriteLine("Os elementos copiados no segundo array são:");
        ExibirArray(arrayCopia);
    }

    static void ExibirArray(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.Write($"{elemento} ");
        }
        Console.WriteLine();
    }
}
