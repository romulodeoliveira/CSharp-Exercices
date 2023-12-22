/*
Escreva um programa C#Sharp para exibir um padrão de alfabeto como Z com um asterisco.

Exiba o padrão como 'Z' com um asterisco:
---------------------------------------------

*******
     *
    *
   *
  *
 *
*******
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternZ();
 }

 static void DisplayAlphabetPatternZ()
 {
  Console.WriteLine("Exibe o padrão como 'Z' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 7; j++)
   {
    if (i == 1 || i == 7 || i + j == 8)
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
