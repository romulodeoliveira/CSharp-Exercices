using System;

/*
Escreva um programa C# que receba um número como entrada e exiba um retângulo de 3 colunas de largura e 5 linhas de altura usando esse dígito.

Dados de teste:
Digite um número: 5
Saída esperada:
555
5 5
5 5
5 5
555
*/

namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            string v1 = Console.ReadLine();

            if (int.TryParse(v1, out int n1))
            {
                if (n1 < 10)
                {
                    for (int a = 0; a < 3; a++)
                    {
                        System.Console.Write(n1);
                    }

                    System.Console.WriteLine();

                    for (int b = 0; b < 3; b++)
                    {
                        System.Console.WriteLine($"{n1} {n1}");
                    }

                    for (int c = 0; c < 3; c++)
                    {
                        System.Console.Write(n1);
                    }

                    System.Console.WriteLine();
                }

                else
                {
                    for (int a = 0; a < 3; a++)
                    {
                        System.Console.Write(n1);
                    }

                    System.Console.WriteLine();

                    for (int b = 0; b < 3; b++)
                    {
                        System.Console.WriteLine($"{n1}  {n1}");
                    }

                    for (int c = 0; c < 3; c++)
                    {
                        System.Console.Write(n1);
                    }

                    System.Console.WriteLine();
                }
            }


            else
            {
                System.Console.WriteLine("Entrada de dados inválida. Insira apenas números inteiros.");
            }
        }
    }
}