/*
Escreva um programa C# Sharp para contar a frequência de cada elemento em uma matriz.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 25
elemento - 1: 12
elemento - 2: 43
Saída esperada :
Frequência de todos os elementos da matriz:
25 ocorre 1 vez
ocorre 12 1 vez
ocorre 43 1 vez
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

        Dictionary<int, int> frequencia = ContarFrequencia(array);

        Console.WriteLine("\nFrequência de todos os elementos da matriz:");
        ExibirFrequencia(frequencia);
    }

    static Dictionary<int, int> ContarFrequencia(int[] array)
    {
        Dictionary<int, int> frequencia = new Dictionary<int, int>();

        foreach (int elemento in array)
        {
            if (frequencia.ContainsKey(elemento))
            {
                frequencia[elemento]++;
            }
            else
            {
                frequencia[elemento] = 1;
            }
        }

        return frequencia;
    }

    static void ExibirFrequencia(Dictionary<int, int> frequencia)
    {
        foreach (var par in frequencia)
        {
            Console.WriteLine($"{par.Key} ocorre {par.Value} vez{(par.Value == 1 ? "" : "es")}");
        }
    }
}
