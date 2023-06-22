using System;

/*
Escreva um programa C# Sharp para encontrar a soma cumulativa de uma matriz de números.

Uma soma cumulativa é uma sequência de somas parciais de uma determinada sequência. Por exemplo, as somas cumulativas da sequência {x, y, z,...}, são x , x+y , x+y+z
Exemplo de saída:
Original Elementos da matriz:
1 3 4 5 6 7
Soma cumulativa dos os referidos elementos da matriz:
1 4 8 13 19 26
Elementos originais da matriz:
1,2 -3 4,1 6 -5,47
Soma cumulativa dos referidos elementos da matriz:
1,2 -1,8 2,3 8,3 2,83
*/

namespace Exercice85;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[] { 1, 3, 4, 5, 6, 7 };
        int[] array2 = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            if (i == 0)
            {
                array2[i] = array1[i];
            }
            else
            {
                array2[i] = array2[i - 1] + array1[i];
            }
        }

        Console.Write("Array1: ");
        for (int j = 0; j < array1.Length; j++)
        {
            Console.Write($"{array1[j]} ");
        }
        Console.WriteLine();

        Console.Write("Array2: ");
        for (int l = 0; l < array2.Length; l++)
        {
            Console.Write($"{array2[l]} ");
        }
        Console.WriteLine();
    }
}