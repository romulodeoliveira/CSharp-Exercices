/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como G com um asterisco.

Exiba o padrão como 'G' com um asterisco:
---------------------------------------------

  ***
 * *
 *
 * ***
 * *
 * *
  ***
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternG();
    }

    static void DisplayAlphabetPatternG()
    {
        Console.WriteLine("Exibe o padrão como 'G' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if ((i == 1 && (j != 2 && j != 3)) || (i == 7 && j != 4) || ((j == 1 || j == 4) && (i > 1 && i < 7)) || (i == 4 && (j == 2 || j == 3)))
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
