/*
Escreva um programa em C# Sharp para exibir tal padrão para n número de linhas usando um número começando com o número 1. O primeiro e o último número de cada linha serão 1.

  1
 121
12321
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de linhas: ");
        int n = int.Parse(Console.ReadLine());

        PrintPattern(n);

        Console.ReadLine();
    }

    static void PrintPattern(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}
