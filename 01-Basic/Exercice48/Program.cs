using System;

/*
Escreva um programa C# para verificar se o primeiro elemento e o último elemento são iguais em uma matriz de inteiros e se o comprimento é 1 ou mais.

Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
True
*/

namespace Exercice48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };

            if (nums.Length > 1 && nums[0] == nums[nums.Length - 1])
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