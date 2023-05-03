using System;

/*
Escreva um programa C# para verificar se o primeiro elemento ou o último elemento das duas matrizes (comprimento 1 ou mais) são iguais.

Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
Verifique se o primeiro elemento ou o último elemento das duas matrizes ( comprimento 1 ou mais) são iguais.
Sample Output
True
*/

namespace Exercice49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsOne = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int[] numsTwo = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };

            if (numsOne.Length > 1 && numsTwo.Length > 1 && numsOne[0] == numsTwo[0] || numsOne[numsOne.Length - 1] == numsTwo[numsTwo.Length - 1])
            {
                System.Console.WriteLine("True");
            }

            else
            {
                System.Console.WriteLine("False");
            }
        }
    }
}