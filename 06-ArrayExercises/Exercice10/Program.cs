/*
Escreva um programa em C# Sharp para separar inteiros pares e ímpares em arrays separados.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 5
Insira 5 elementos na matriz:
elemento - 0: 25
elemento - 1: 47
elemento - 2: 42
elemento - 3: 56
elemento - 4: 32
Saída esperada :
Os elementos pares são:
42 56 32
Os elementos ímpares são:
25 47
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

        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        foreach (int elemento in array)
        {
            if (elemento % 2 == 0)
            {
                pares.Add(elemento);
            }
            else
            {
                impares.Add(elemento);
            }
        }

        Console.WriteLine("\nOs elementos pares são:");
        ExibirArray(pares.ToArray());

        Console.WriteLine("Os elementos ímpares são:");
        ExibirArray(impares.ToArray());
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
