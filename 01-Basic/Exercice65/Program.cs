using System;

// Escreva um programa C# Sharp para multiplicar todos os elementos de uma determinada matriz de números pelo comprimento da matriz.

namespace Exercice65
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 6, 8 };

            int i = 0;
            while (i < nums.Length)
            {
                System.Console.Write($"| {nums[i] * nums.Length} ");
                i++;
            }
            System.Console.Write("|");
            System.Console.WriteLine();
        }
    }
}
