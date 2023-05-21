using System;

/*
Escreva um programa C# Sharp para aceitar dois números inteiros e verificar se eles são iguais ou não.

Dados de teste:
Entrada 1º número: 5
Entrada 2º número: 5

Saída esperada :
5 e 5 são iguais
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            if (a == b)
            {
                System.Console.WriteLine("Os números são iguais.");
            }

            else
            {
                System.Console.WriteLine("Os números não são iguais.");
            }
        }
    }
}