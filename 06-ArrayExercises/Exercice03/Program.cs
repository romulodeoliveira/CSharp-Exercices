/*
Escreva um programa em C# Sharp para encontrar a soma de todos os elementos do array.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 2
elemento - 1: 5
elemento - 2: 8
Saída esperada :
A soma de todos os elementos armazenados na matriz é : 15
*/

using System;

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

        int soma = 0;
        foreach (int elemento in array)
        {
            soma += elemento;
        }

        Console.WriteLine($"A soma de todos os elementos armazenados na matriz é: {soma}");
    }
}
