using System;

/*
Escreva um programa C# para verificar se um número aparece como o primeiro ou o último elemento de uma matriz de inteiros e se o comprimento é 1 ou mais.

Dados de teste:
Insira um número inteiro: 25
Exemplo de saída
Falso
*/

namespace Exercice46
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número inteiro: ");
            string str = Console.ReadLine();

            int[] nums = new int[] { 23, 26, 27, 28, 50, 40, 9, 47, 97 };

            if (int.TryParse(str, out int num))
            {
                if (num == nums[0] || num == nums[nums.Length - 1])
                {
                    System.Console.WriteLine("True");
                }

                else
                {
                    System.Console.WriteLine("False");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}