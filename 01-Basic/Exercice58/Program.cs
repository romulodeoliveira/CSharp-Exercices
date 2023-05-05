using System;

/*
Escreva um programa em C# que aceite uma lista de inteiros e verifique quantos inteiros são necessários para completar o intervalo.

Amostra Exemplo:

[1, 3, 4, 7, 9], entre 1-9 -> 2, 5, 6, 8 não estão presentes na lista. Portanto, a saída será 4.
*/

namespace Exercice58
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira números separados por espaços: ");
            string str = Console.ReadLine();

            string[] values = str.Split(" ");
            int[] nums = new int[values.Length];

            int i = 0;
            int j = 0;

            while (i < values.Length)
            {
                if (int.TryParse(values[i], out nums[i]))
                {
                    if (nums[i] > 1 && nums[i] < 9)
                    {
                        j++;
                    }
                }

                i++;
            }
            System.Console.WriteLine($"{j}");
        }
    }
}