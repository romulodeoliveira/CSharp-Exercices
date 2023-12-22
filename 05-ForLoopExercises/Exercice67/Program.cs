/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como J com um asterisco.
Exiba o padrão como 'J' com um asterisco:
---------------------------------------------

   ***
    *
    *
    *
    *
  * *
   *
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternJ();
    }

    static void DisplayAlphabetPatternJ()
    {
        Console.WriteLine("Exibe o padrão como 'J' com um asterisco:");

        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if ((i == 1 && j != 5) || (j == 3 && i != 1 && i != 7) || (i > 1 && i < 7 && j == 1) || (i == 7 && j <= 4))
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
