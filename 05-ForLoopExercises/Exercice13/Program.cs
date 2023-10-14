/*
Escreva um programa em C# Sharp para fazer um padrão como uma pirâmide com números aumentando em 1.

   1
  2 3
 4 5 6
7 8 9 10
*/

using System;

class Program
{
    static void Main()
    {
        int n = 4;

        int num = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write("  ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(num.ToString().PadLeft(2) + " ");
                num++;
            }

            Console.WriteLine();
        }
    }
}
