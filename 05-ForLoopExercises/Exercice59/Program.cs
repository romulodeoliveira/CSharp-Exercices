/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como B com um asterisco.

Exiba o padrão como 'B' com um asterisco:
---------------------------------------------

 ****
 * *
 * *
 ****
 * *
 * *
 ****
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternB();
 }

 static void DisplayAlphabetPatternB()
 {
  Console.WriteLine("Exibe o padrão como 'B' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 4; j++)
   {
    if ((i == 1 || i == 7 || i == 4) || (j == 1 && i < 4) || (j == 4 && i > 4))
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
