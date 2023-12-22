/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como I com um asterisco.

Exiba o padrão como 'I' com um asterisco:
---------------------------------------------

 *****
   *
   *
   *
   *
   *
 *****
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternI();
    }

    static void DisplayAlphabetPatternI()
    {
        Console.WriteLine("Exibe o padrão como 'I' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((i == 1 || i == 7) || (j == 3 && i != 1 && i != 7))
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
