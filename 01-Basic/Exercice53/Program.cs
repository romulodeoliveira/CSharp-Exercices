using System;

/*
Escreva um programa em C# para verificar se um array contém um número ímpar.

Dados de teste:
Matriz original: [2, 4, 7, 8, 6]
Verifique se uma matriz contém um número ímpar? Verdadeiro
*/

namespace Exercice53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 4, 7, 8, 6 };
            bool ifNums = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    ifNums = true;
                }
            }

            if (ifNums)
            {
                System.Console.WriteLine("Verdadeiro");
            }

            else
            {
                System.Console.WriteLine("Falso");
            }
        }
    }
}