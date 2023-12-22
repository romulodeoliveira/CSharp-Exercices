/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como T com um asterisco.

Exiba o padrão como 'T' com um asterisco:
---------------------------------------------

 *****
   *
   *
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
        DisplayAlphabetPatternT();
    }

    static void DisplayAlphabetPatternT()
    {
        Console.WriteLine("Exibe o padrão como 'T' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (i == 1 || j == 3)
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
