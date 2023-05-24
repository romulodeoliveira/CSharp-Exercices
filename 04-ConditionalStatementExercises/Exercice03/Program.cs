using System;

/*
Escreva um programa C# Sharp para verificar se um determinado número é positivo ou negativo.

Dados de teste: 14

Saída esperada :
14 é um número positivo
*/

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            if (num >= 0)
            {
                System.Console.WriteLine("Positivo");
            }
            else
            {
                System.Console.WriteLine("Negativo");
            }
        }
    }
}