using System;

/*
Escreva um programa C# para ler n valores em uma matriz e exibi-los na ordem inversa.

Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira o número de 3 elementos na matriz:
elemento - 0: 2
elemento - 1: 5
elemento - 2: 7
Saída esperada :

Os valores armazenados na matriz são:
2 5 7

Os valores armazenados no array ao contrário são:
7 5 2
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[] { "banana", "orange", "apple", "lemon", "avocados" };

            for (int i = fruits.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine($"Elemento - {i}: {fruits[i]}");
            }
        }
    }
}