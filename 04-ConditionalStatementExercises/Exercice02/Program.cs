using System;

/*
Escreva um programa C# Sharp para verificar se um determinado número é par ou ímpar.

Dados de teste: 15

Saída esperada :
15 é um inteiro ímpar
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;

            if (a % 2 == 0)
            {
                System.Console.WriteLine("Par");
            }

            else
            {
                System.Console.WriteLine("Impar");
            }
        }
    }
}