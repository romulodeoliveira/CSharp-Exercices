/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como L com um asterisco.
Exiba o padrão como 'L' com um asterisco:
---------------------------------------------

 *
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
  DisplayAlphabetPatternL();
 }

 static void DisplayAlphabetPatternL()
 {
  Console.WriteLine("Exibe o padrão como 'L' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if (j == 1 || i == 7)
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
