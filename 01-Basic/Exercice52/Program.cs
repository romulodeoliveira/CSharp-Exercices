using System;

/*
Escreva um programa em C# para criar uma nova matriz de comprimento contendo os elementos intermediários de três matrizes (cada uma com tamanho 3) de inteiros.

Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0]
*/

namespace Exercice52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsOne = new int[] { 1, 2, 5 };
            int[] numsTwo = new int[] { 0, 3, 8 };
            int[] numsThree = new int[] { -1, 0, 2 };

            int[] newArray = new int[] { numsOne[1], numsTwo[1], numsThree[1] };

            System.Console.WriteLine("Novo array: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] != newArray[newArray.Length - 1])
                {
                    System.Console.Write($"{newArray[i]}, ");
                }

                else
                {
                    System.Console.Write($"{newArray[i]}");
                }
            }
            System.Console.WriteLine();
        }
    }
}