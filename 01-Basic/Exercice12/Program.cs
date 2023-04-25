using System;

/*
Escreva um programa em C# que receba um número como entrada e o exiba quatro vezes seguidas (separadas por espaços em branco) e, a seguir, quatro vezes na próxima linha, sem separação. Você deve fazer isso duas vezes:

Dados de teste:
Digite um dígito: 25
Saída esperada:
25 25 25 25
25252525
25 25 25 25
25252525
*/

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            string v1 = Console.ReadLine();

            if (int.TryParse(v1, out int n1))
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int a = 0; a < 4; a++)
                    {
                        System.Console.Write(n1 + " ");
                    }

                    System.Console.WriteLine();

                    for (int b = 0; b < 4; b++)
                    {
                        System.Console.Write(n1);
                    }

                    System.Console.WriteLine();
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Use apenas números inteiros.");
            }
        }
    }
}