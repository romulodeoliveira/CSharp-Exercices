using System;

// Escreva um programa C# para encontrar o par de elementos adjacentes que tem o maior produto de um determinado array de inteiros.

namespace Exercice57
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int maxProduct = int.MinValue;
            int maxIndex = -1;

            int i = 0;

            while (i < nums.Length - 1)
            {
                int product = nums[i] * nums[i + 1];
                if (product > maxProduct)
                {
                    maxProduct = product;
                    maxIndex = i;
                }
                i++;
            }

            if (maxIndex != -1)
            {
                int num1 = nums[maxIndex];
                int num2 = nums[maxIndex + 1];

                Console.WriteLine($"O par de elementos adjacentes com o maior produto é: {num1} e {num2}");

                Console.WriteLine($"O produto é: {maxProduct}");
            }

            else
            {
                Console.WriteLine("Não há elementos suficientes para calcular o produto.");
            }
        }
    }
}
