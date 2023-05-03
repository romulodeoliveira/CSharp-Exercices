using System;

// Escreva um programa C# para obter o século de um ano.

namespace Exercice54
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;

            int seculo = (int)Math.Ceiling((double)year / 100);

            Console.WriteLine($"O século do ano {year} é o {seculo}º século.");
        }
    }
}