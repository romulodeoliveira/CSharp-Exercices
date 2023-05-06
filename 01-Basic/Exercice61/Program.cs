using System;

// Escreva um programa C# para classificar os inteiros em ordem crescente sem mover o número -5.

namespace Exercice61
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, -5, 7, 3, 0, 2 };

            int indexOfNegativeFive = Array.IndexOf(nums, -5);

            if (indexOfNegativeFive != -1)
            {
                int[] numbersToSort = nums.Where(n => n != -5).ToArray();
                Array.Sort(numbersToSort);

                int[] sortedNumbers = new int[nums.Length];
                Array.Copy(nums, sortedNumbers, nums.Length);

                for (int i = 0; i < numbersToSort.Length; i++)
                {
                    sortedNumbers[i] = numbersToSort[i];
                }

                Console.WriteLine("Números classificados em ordem crescente sem mover o -5:");
                foreach (int number in sortedNumbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("O número -5 não está presente no array.");
            }
        }
    }
}