using System;

/*
Escreva um programa em C# para calcular a soma de todos os elementos de um array de inteiros.

Test Data:
Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
Sample Output
Sum: 69
*/

namespace Exercice47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int sum = 0;
            int i = 0;

            while (i < nums.Length)
            {
                sum = sum + nums[i];

                i++;
            }

            System.Console.WriteLine(sum);
        }
    }
}