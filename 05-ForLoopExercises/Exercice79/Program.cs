/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como V com um asterisco.

Exiba o padrão como 'V' com um asterisco:
---------------------------------------------

 * *
 * *
 * *
 * *
 * *
  * *
   *
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternV();
    }

    static void DisplayAlphabetPatternV()
    {
        Console.WriteLine("Exibe o padrão como 'V' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((i <= 5 && (j == 1 || j == 5 || (i % 2 == 0 && (j == 2 || j == 4)))) || (i > 5 && (j == 2 || j == 4)))
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
