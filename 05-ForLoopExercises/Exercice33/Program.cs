/*
Escreva um programa C# Sharp para exibir o triângulo de Pascal.
 Dados de teste:
Número de linhas de entrada: 5
Saída esperada :

1 1 1 1 2 1 1 3 3 1 1 4 6 4 1
*/

using System;

class Program
{
 static void Main()
 {
  Console.Write("Número de linhas de entrada: ");
  int numRows = int.Parse(Console.ReadLine());

  PrintPascalTriangle(numRows);

  Console.ReadLine(); // Para manter a janela do console aberta
 }

 static void PrintPascalTriangle(int numRows)
 {
  for (int i = 0; i < numRows; i++)
  {
   int num = 1;

   // Imprime espaços em branco à esquerda
   for (int j = 0; j < numRows - i; j++)
   {
    Console.Write(" ");
   }

   for (int j = 0; j <= i; j++)
   {
    Console.Write(num + " ");
    num = num * (i - j) / (j + 1);
   }

   Console.WriteLine();
  }
 }
}
