/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como S com um asterisco.

Exiba o padrão como 'S' com um asterisco:
---------------------------------------------

  ****
 *
 *
  ***
     *
     *
 ****
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternS();
    }

    static void DisplayAlphabetPatternS()
    {
        Console.WriteLine("Exibe o padrão como 'S' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((i == 1 || i == 4 || i == 7) && j < 5 || (i > 1 && i < 4 && j == 1) || (i > 4 && i < 7 && j == 5) || (i == 2 && j == 5) || (i == 3 && j == 5) || (i == 5 && j == 1) || (i == 6 && j == 1))
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
