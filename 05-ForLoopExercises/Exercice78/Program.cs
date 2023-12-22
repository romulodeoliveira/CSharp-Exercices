/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como U com um asterisco.

Exiba o padrão como 'U' com um asterisco:
---------------------------------------------

 * *
 * *
 * *
 * *

 * *
 * *
  ***
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternU();
    }

    static void DisplayAlphabetPatternU()
    {
        Console.WriteLine("Exibe o padrão como 'U' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((j == 1 || j == 5) || (i > 1 && i < 7 && (j == 2 || j == 4)))
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
