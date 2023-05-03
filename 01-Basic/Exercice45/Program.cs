using System;

/*
Escreva um programa C# para contar um número especificado em uma determinada matriz de inteiros.

Dados de teste:
Insira um número inteiro: 5
Exemplo de saída
Número de 5 presente no referido array: 2
*/

namespace Exercice45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            string str = Console.ReadLine();
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };


            if (int.TryParse(str, out int num))
            {
                int frequency = nums.Count(n => n == num);

                Console.WriteLine($"O número {num} se repete {frequency} vez(es) no array.");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}