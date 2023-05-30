using System;

/*
Escreva um programa C# que receba um número positivo e retorne o n-ésimo número ímpar.

Exemplo de Saída:
1º número ímpar: 1
2º número ímpar: 3
4º número ímpar: 7
100º número ímpar: 199
*/

namespace Exercice75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int num))
            {
                if (num >= 1)
                {
                    int oddNumber = 0;
                    int count = 1;

                    while (count <= num)
                    {
                        if (oddNumber % 2 == 1)
                        {
                            System.Console.WriteLine($"{count}º número ímpar: {oddNumber}");
                            count++;
                        }

                        oddNumber++;
                    }
                }

                else
                {
                    System.Console.WriteLine("Você precisa inserir um número inteiro.");
                }
            }

            else
            {
                System.Console.WriteLine("Você precisa inserir um número inteiro.");
            }
        }
    }
}