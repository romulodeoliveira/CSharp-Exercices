using System;
using Exercice72;

/*
Escreva um programa C# para verificar se o valor médio dos elementos de uma determinada matriz de números é um número inteiro ou não.

Exemplo de saída:

nums = { 1, 2, 3, 5, 4, 2, 3, 4 }

Verifique se o valor médio do referido array é um número inteiro ou não: True

nums1 = { 2, 4, 2 , 6, 4, 8 }

Verifique se o valor médio do referido array é um número inteiro ou não: Falso
*/

namespace Exercice72
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 5, 4, 2, 3, 4 };
            bool isAverageInteger = CheckAverage.CheckAverageInteger(nums1);
            Console.WriteLine("A média do array nums1 é inteiro: " + isAverageInteger);

            int[] nums2 = { 2, 4, 2, 6, 4, 8 };
            isAverageInteger = CheckAverage.CheckAverageInteger(nums2);
            Console.WriteLine("A média do array nums2 é inteiro: " + isAverageInteger);
        }
    }
}