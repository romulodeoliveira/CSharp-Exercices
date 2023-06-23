using System;

/*
Escreva um programa C# Sharp para contar números positivos e negativos em uma determinada matriz de inteiros.

Exemplo de Saída:
Elementos do Array Original:
10 -11 12 -13 14 -18 19 -20
Número de números positivos: 4
Número de números negativos: 4
Elementos do Array Original:
-4 -3 -2 0 3 5 6 2 6
Número de números positivos: 5
Número de números negativos: 3
Elementos originais do Array:
Número de números positivos: 0
Número de números negativos: 0
*/

namespace Exercice89;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[] { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

        int amountOfPositiveNumbers = 0;
        int amountOfNegativeNumbers = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] > 0)
            {
                amountOfPositiveNumbers += 1;
            }
            else
            {
                amountOfNegativeNumbers += 1;
            }
        }

        Console.WriteLine($"Quantidade de numeros positivos: {amountOfPositiveNumbers}\nQuantidade de numeros negativos: {amountOfNegativeNumbers}");
    }
}