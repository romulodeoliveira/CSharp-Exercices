/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como E com um asterisco.

Exiba o padrão como 'E' com um asterisco:
---------------------------------------------

 *****
 *
 *
 ****
 *
 *
 *****
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternE();
 }

 static void DisplayAlphabetPatternE()
 {
  Console.WriteLine("Exibe o padrão como 'E' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if ((i == 1 || i == 7) || (j == 1) || (j == 5 && i != 1 && i != 7))
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
