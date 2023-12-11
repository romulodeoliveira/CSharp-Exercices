/*
Escreva um programa C# Sharp para classificar os elementos de um array em ordem crescente.
Dados de teste:
Insira o tamanho da matriz: 5
Insira 5 elementos na matriz:
elemento - 0: 2
elementos - 1: 7
elementos - 2: 4
elementos - 3: 5
elementos - 4: 9
Saída esperada :
Elementos da matriz classificados ordem crescente:
2 4 5 7 9
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        OrdenarArray(array);

        Console.WriteLine("\nElementos da matriz classificados em ordem crescente:");
        ExibirArray(array);
    }

    static void OrdenarArray(int[] array)
    {
        Array.Sort(array);
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
