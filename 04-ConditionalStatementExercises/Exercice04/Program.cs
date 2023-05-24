using System;

/*
Escreva um programa C# Sharp para descobrir se um determinado ano é bissexto ou não.

Dados de teste: 2016

Saída esperada :
2016 é um ano bissexto.
*/

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 2002;

            if (year % 4 == 0)
            {
                System.Console.WriteLine("Bissexto.");
            }

            else
            {
                System.Console.WriteLine("Não bissexto.");
            }
        }
    }
}