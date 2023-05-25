using System;

/*
Escreva um programa C# para encontrar a soma dos primeiros 10 números naturais.
Resultado Esperado :
Os primeiros 10 números naturais são:
1 2 3 4 5 6 7 8 9 10
A soma é: 55
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i < 11; i++)
            {
                System.Console.Write($"{i} ");
                total += i;
            }
            System.Console.WriteLine($"\nA soma é: {total}");
        }
    }
}