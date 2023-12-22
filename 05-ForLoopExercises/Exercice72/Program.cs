/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como um O com um asterisco.

Exiba o padrão como 'O' com um asterisco:
---------------------------------------------

  ***
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
        DisplayAlphabetPatternO();
    }

    static void DisplayAlphabetPatternO()
    {
        Console.WriteLine("Exibe o padrão como 'O' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((i == 1 || i == 7) && (j == 2 || j == 3 || j == 4))
                {
                    Console.Write("*");
                }
                else if ((i > 1 && i < 7) && (j == 1 || j == 5))
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
