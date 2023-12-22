/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como Q com um asterisco.

Exiba o padrão como 'Q' com um asterisco:
---------------------------------------------

  ***
 * *
 * *
 * *
 * * *
 * *
  ** *
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternQ();
    }

    static void DisplayAlphabetPatternQ()
    {
        Console.WriteLine("Exibe o padrão como 'Q' com um asterisco:");

        for (int i = 1; i <= 8; i++)
        {
            for (int j = 1; j <= 6; j++)
            {
                if ((i == 1 && (j == 2 || j == 3 || j == 4)) || (i > 1 && i < 5 && (j == 1 || j == 5)) || (i == 5 && (j == 1 || j == 5 || j == 6)) || (i > 5 && i < 8 && j == 6))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
