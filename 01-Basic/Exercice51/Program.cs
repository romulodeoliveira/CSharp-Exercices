using System;

/*
Escreva um programa C# para obter o maior valor entre o primeiro e o último elemento de uma matriz (comprimento 3) de inteiros.

Dados de teste:
Array1: [1, 2, 5, 7, 8]
Maior valor entre o primeiro e o último valor do referido array: 8
*/

namespace Exercice51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 7, 8 };
            int higherNumber = int.MinValue;

            int i = 0;

            while (i < nums.Length)
            {
                if (nums[i] > higherNumber)
                {
                    higherNumber = nums[i];
                }

                i++;
            }

            Console.WriteLine($"O maior número é: {higherNumber}");
        }
    }
}