/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como A com um asterisco.

A string invertida é: Exibe o padrão como 'A' com um asterisco:
---------------------------------------------

  ***
 * *
 * *
 *****
 * *
 * *
 * *
 * *
*/

using System;

class Program
{
    static void Main()
    {
        DisplayAlphabetPatternA();
    }

    static void DisplayAlphabetPatternA()
    {
        Console.WriteLine("Exibe o padrão como 'A' com um asterisco:");
        
        for (int i = 1; i <= 7; i++)
        {
            for (int j = 1; j <= 7; j++)
            {
                if ((i == 1 && j % 3 != 0) || (i > 1 && (j == 1 || j == 7)) || (i == 4 && j % 3 == 0))
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
