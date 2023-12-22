/*
Escreva um programa C# Sharp para exibir um padrão de alfabeto como M com um asterisco.
Exiba o padrão como 'M' com um asterisco:
---------------------------------------------

 * *
 * *
 ** **
 * * *
 * *
 * *
 * *
*/

using System;

class Program
{
 static void Main()
 {
  DisplayAlphabetPatternM();
 }

 static void DisplayAlphabetPatternM()
 {
  Console.WriteLine("Exibe o padrão como 'M' com um asterisco:");

  for (int i = 1; i <= 7; i++)
  {
   for (int j = 1; j <= 6; j++)
   {
    if (j == 1 || j == 6 || (i <= 3 && (j == i || j == 7 - i)) || (i > 3 && j == 4 - (i - 3)))
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
