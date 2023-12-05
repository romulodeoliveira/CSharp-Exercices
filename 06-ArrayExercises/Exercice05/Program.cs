/*
Escreva um programa C# Sharp para contar elementos duplicados em uma matriz.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 5
elemento - 1: 1
elemento - 2: 1
Saída esperada :
Número total de elementos duplicados encontrados na matriz é: 1
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

        int duplicados = ContarElementosDuplicados(array);

        Console.WriteLine($"Número total de elementos duplicados encontrados na matriz é: {duplicados}");
    }

    static int ContarElementosDuplicados(int[] array)
    {
        HashSet<int> conjunto = new HashSet<int>();
        HashSet<int> duplicados = new HashSet<int>();

        foreach (int elemento in array)
        {
            if (!conjunto.Add(elemento))
            {
                duplicados.Add(elemento);
            }
        }

        return duplicados.Count;
    }
}
