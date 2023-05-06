using System;

/*
Escreva um programa C# para calcular a soma de todos os inteiros de uma matriz retangular, exceto os inteiros que estão localizados abaixo de um inteiro de valor 0.

Exemplo:

matriz = [[0, 2, 3, 2] ,
[0, 6, 0, 1],
[4, 0, 3, 0]]

Números inteiros elegíveis que participarão do cálculo da soma matriz = [[X, 2, 3, 2],
[X, 6, X, 1],
[X, X, X, X]]

Portanto a soma será: 2 + 3 + 2 + 6 + 1 = 14
*/

namespace Exercice60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, 2, 3, 2, 6, 1 };

            int total = 0;
            int i = 0;

            while (i < nums.Length)
            {
                if (nums[i] >= 0)
                {
                    total = total + nums[i];
                }

                i++;
            }

            System.Console.WriteLine(total);
        }
    }
}