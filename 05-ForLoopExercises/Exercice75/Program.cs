/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como R com um asterisco.

Exiba o padrão como 'R' com um asterisco:
---------------------------------------------

 ****
 * *
 * *
 ****
 * *
 * *
 * *
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternR();
 }

 static void DisplayAlphabetPatternR()
 {
  Console.WriteLine("Exibe o padrão como 'R' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if ((j == 1 || j == 5) || (i == 1 || i == 4) && j < 5 || (i > 1 && i < 4 && j == 5) || (i == 5 && j == 2) || (i == 6 && j == 3) || (i == 7 && j == 4))
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
