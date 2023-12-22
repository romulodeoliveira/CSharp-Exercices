/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como C com um asterisco.

Exiba o padrão como 'C' com um asterisco:
---------------------------------------------

  ***
 * *
 *
 *
 *
 * *
  ***
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternC();
    }

    static void DisplayAlphabetPatternC()
    {
        Console.WriteLine("Exibe o padrão como 'C' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                if ((i == 1 || i == 7) || (j == 1 && i > 1 && i < 7) || (j > 1 && i == 1))
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
