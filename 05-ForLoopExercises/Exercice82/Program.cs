/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como Y com um asterisco.

Exiba o padrão como 'Y' com um asterisco:
---------------------------------------------

 *       *
  *     *
    * *
     *
     *
     *
     *
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternY();
    }

    static void DisplayAlphabetPatternY()
    {
        Console.WriteLine("Exibe o padrão como 'Y' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                if ((j == 1 || j == 7) && (i <= 4) || (i == j) && (j > 1 && j < 4) || (i + j == 8) && (j > 4 && j < 7))
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
