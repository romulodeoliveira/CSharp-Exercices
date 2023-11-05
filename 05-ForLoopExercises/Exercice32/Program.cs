/*
Escreva um programa C# Sharp para determinar se um determinado número é primo ou não.
 Dados de teste:
Insira um número: 13
Saída esperada :
13 é um número primo.
*/

using System;

class Program
{
 static void Main()
 {
  Console.Write("Insira um número: ");
  int number = int.Parse(Console.ReadLine());

  if (IsPrime(number))
  {
   Console.WriteLine($"{number} é um número primo.");
  }
  else
  {
   Console.WriteLine($"{number} não é um número primo.");
  }

  Console.ReadLine();
 }

 static bool IsPrime(int num)
 {
  if (num <= 1)
  {
   return false;
  }

  for (int i = 2; i <= Math.Sqrt(num); i++)
  {
   if (num % i == 0)
   {
    return false;
   }
  }

  return true;
 }
}
