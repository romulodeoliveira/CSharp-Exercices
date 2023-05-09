using System;

// Escreva um programa C# para verificar se um determinado número está presente em uma matriz de números.

namespace Exercice63
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int[] nums = new int[] { 1, 3, 5, 7, 9 };
            bool isPresent = false;
            int i = 0;

            while (i < nums.Length)
            {
                if (num == nums[i])
                {
                    isPresent = true;
                    break;
                }

                i++;
            }

            if (isPresent)
            {
                System.Console.WriteLine("Está presente");
            }

            else
            {
                System.Console.WriteLine("Não está presente");
            }
        }
    }
}