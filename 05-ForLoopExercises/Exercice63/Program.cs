/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como F com um asterisco.

Exiba o padrão como 'F' com um asterisco:
---------------------------------------------

 *****
 *
 *
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
  DisplayAlphabetPatternF();
 }

 static void DisplayAlphabetPatternF()
 {
  Console.WriteLine("Exibe o padrão como 'F' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 5; j++)
   {
    if ((i == 1) || (j == 1) || (j == 5 && i <= 4))
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
