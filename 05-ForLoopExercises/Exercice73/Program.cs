/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como P com um asterisco.

Exiba o padrão como 'P' com um asterisco:
---------------------------------------------

 ****
 * *
 * *
 ****
 *
 *
 *
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternP();
 }

 static void DisplayAlphabetPatternP()
 {
  Console.WriteLine("Exibe o padrão como 'P' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if ((j == 1 || j == 5) || ((i == 1 || i == 4) && j < 5) || (i > 1 && i < 4 && j == 5))
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
