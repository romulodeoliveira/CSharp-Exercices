using System;

/*
Escreva um programa C# para girar uma matriz (comprimento 3) de inteiros na direção esquerda.

Dados de teste:
Array1: [1, 2, 8]
Após a rotação, o array se torna: [2, 8, 1]
*/

namespace Exercice50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 8 };

            System.Console.Write("Array original: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[nums.Length - 1])
                {
                    System.Console.Write($"{nums[i]}, ");
                }

                else
                {
                    System.Console.Write($"{nums[i]}");
                }
            }
            System.Console.WriteLine();

            int temp = nums[0];
            nums[0] = nums[1];
            nums[1] = nums[2];
            nums[2] = temp;

            System.Console.Write("Array rotacionado: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != nums[nums.Length - 1])
                {
                    System.Console.Write($"{nums[i]}, ");
                }

                else
                {
                    System.Console.Write($"{nums[i]}");
                }
            }
            System.Console.WriteLine();
        }
    }
}