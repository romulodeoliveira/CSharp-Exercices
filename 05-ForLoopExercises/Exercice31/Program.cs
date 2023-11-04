/*
Escreva um programa em C# Sharp para exibir o padrão como um diamante.

    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
*/

using System;

class Program
{
 static void Main()
 {
  Console.Write("Insira o número de linhas do diamante (deve ser ímpar): ");
  int n = int.Parse(Console.ReadLine());

  if (n % 2 == 0)
  {
   Console.WriteLine("O número de linhas deve ser ímpar.");
   return;
  }

  PrintDiamondPattern(n);

  Console.ReadLine();
 }

 static void PrintDiamondPattern(int n)
 {
  int spaces = n / 2;
  int stars = 1;

  for (int i = 0; i < n / 2 + 1; i++)
  {
   for (int j = 0; j < spaces; j++)
   {
    Console.Write(" ");
   }

   for (int j = 0; j < stars; j++)
   {
    Console.Write("*");
   }

   Console.WriteLine();

   spaces--;
   stars += 2;
  }

  spaces = 1;
  stars = n - 2;

  for (int i = 0; i < n / 2; i++)
  {
   for (int j = 0; j < spaces; j++)
   {
    Console.Write(" ");
   }

   for (int j = 0; j < stars; j++)
   {
    Console.Write("*");
   }

   Console.WriteLine();

   spaces++;
   stars -= 2;
  }
 }
}
