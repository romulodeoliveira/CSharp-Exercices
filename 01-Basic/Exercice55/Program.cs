using System;

/*
Escreva um programa C# para encontrar o par de elementos adjacentes que tem o maior produto de uma determinada matriz que é igual a um determinado valor.
*/

namespace Exercice55
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 4, 5, 6 };

            int highestValue = int.MinValue;

            int i = 0;
            int j = 1;

            while (j < nums.Length)
            {
                if ((nums[i] * nums[j]) > highestValue)
                {
                    highestValue = nums[i] * nums[j];
                }
                i++;
                j++;
            }

            System.Console.WriteLine(highestValue);
        }
    }
}