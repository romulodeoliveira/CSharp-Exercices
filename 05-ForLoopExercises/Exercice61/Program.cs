/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como D com um asterisco.

Exiba o padrão como 'D' com um asterisco:
---------------------------------------------

 ****
 * *
 * *
 * *
 * *
 * *
 ****
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternD();
 }

 static void DisplayAlphabetPatternD()
 {
  Console.WriteLine("Exibe o padrão como 'D' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 4; j++)
   {
    if ((i == 1 || i == 7) || (j == 1 && i > 1 && i < 7) || (j == 4 && i > 1 && i < 7))
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
