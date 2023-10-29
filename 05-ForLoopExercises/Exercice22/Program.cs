/*
Escreva um programa em C# Sharp para imprimir o Triângulo de Floyd.

1
01
101
0101
10101
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de linhas para o Triângulo de Floyd: ");
        int numberOfRows = Convert.ToInt32(Console.ReadLine());

        DisplayFloydTriangle(numberOfRows);

        Console.ReadLine();
    }

    static void DisplayFloydTriangle(int n)
    {
        Console.WriteLine("Triângulo de Floyd:");

        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{num % 2}");
                num++;
            }

            Console.WriteLine();
        }
    }
}
