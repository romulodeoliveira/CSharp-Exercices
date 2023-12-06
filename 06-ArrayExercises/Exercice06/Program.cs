/*
Escreva um programa em C# Sharp para imprimir todos os elementos únicos em um array.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 1
elemento - 1: 5
elemento - 2: 1
Saída esperada :
Os elementos exclusivos encontrados na matriz são:
5
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de elementos a serem armazenados na matriz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] elementosUnicos = ObterElementosUnicos(array);

        Console.WriteLine("Os elementos exclusivos encontrados na matriz são:");
        ExibirArray(elementosUnicos);
    }

    static int[] ObterElementosUnicos(int[] array)
    {
        HashSet<int> conjunto = new HashSet<int>();

        foreach (int elemento in array)
        {
            conjunto.Add(elemento);
        }

        int[] elementosUnicos = new int[conjunto.Count];
        conjunto.CopyTo(elementosUnicos);

        return elementosUnicos;
    }

    static void ExibirArray(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.WriteLine(elemento);
        }
    }
}
