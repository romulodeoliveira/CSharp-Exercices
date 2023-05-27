using System;

/*
Escreva um programa C# que armazene elementos em um array e os imprima.
Dados de teste:
Insira 10 elementos na matriz:
elemento - 0: 1
elemento - 1: 1
elemento - 2: 2
.......
Saída esperada :
Os elementos na matriz são: 1 1 2 3 4 5 6 7 8 9
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[] { "banana", "orange", "apple", "lemon", "avocados" };

            for (int i = 0; i < fruits.Length; i++)
            {
                System.Console.WriteLine($"Elemento - {i}: {fruits[i]}");
            }
        }
    }
}