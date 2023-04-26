using System;

/*
Escreva um programa C# para calcular a soma de dois números inteiros fornecidos, se dois valores forem iguais, retorne o triplo de sua soma.
*/

namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro número inteiro: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Digite o segundo número inteiro: ");
            string v2 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2))
            {
                if (n1 == n2)
                {
                    System.Console.WriteLine($"Resultado: {3 * n1}");
                }

                else
                {
                    System.Console.WriteLine($"Resultado {n1 + n2}");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados inválida. Digite apenas números inteiros.");
            }
        }
    }
}