/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como N com um asterisco.

Exiba o padrão como 'N' com um asterisco:
---------------------------------------------

 * *
 * *
 ** *
 * * *
 * **
 * *
 * *
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternN();
 }

 static void DisplayAlphabetPatternN()
 {
  Console.WriteLine("Exibe o padrão como 'N' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if (j == 1 || j == 5 || (i > 1 && i < 6 && j == i) || (i > 1 && i < 6 && j == 6 - i))
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
