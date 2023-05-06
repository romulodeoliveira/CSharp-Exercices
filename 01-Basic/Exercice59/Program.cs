using System;

/*
Escreva um programa C# para verificar se é possível criar uma sequência estritamente crescente a partir de uma determinada sequência de inteiros como uma matriz.
*/

namespace Exercice59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os números da sequência separados por espaço: ");
            string str = Console.ReadLine();

            string[] values = str.Split(' ');

            int[] nums = new int[values.Length];

            bool ascendingSequence = true;

            for (int i = 0; i < values.Length; i++)
            {
                nums[i] = int.Parse(values[i]);
            }

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] <= nums[j - 1])
                {
                    ascendingSequence = false;
                    break;
                }
            }

            if (ascendingSequence)
            {
                Console.WriteLine("É possível criar uma sequência estritamente crescente.");
            }

            else
            {
                Console.WriteLine("Não é possível criar uma sequência estritamente crescente.");
            }
        }
    }
}