/*
Escreva um programa C# Sharp para classificar os elementos do array em ordem decrescente.
Dados de teste:
Insira o tamanho da matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 5
elemento - 1: 9
elemento - 2: 1
Saída esperada :
Elementos da matriz em ordem decrescente:
9 5 1
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

        OrdenarArrayDecrescente(array);

        Console.WriteLine("\nElementos da matriz em ordem decrescente:");
        ExibirArray(array);
    }

    static void OrdenarArrayDecrescente(int[] array)
    {
        Array.Sort(array, (a, b) => b.CompareTo(a));
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
