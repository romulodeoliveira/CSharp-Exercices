using System;

/*
Escreva um programa C# para encontrar a soma dos quadrados dos elementos de um determinado array de inteiros.

Exemplo de Saída:
Soma dos quadrados dos elementos do referido array: 14
Soma dos quadrados dos elementos do referido array: 29
*/

namespace Exercice78
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 3 };

            int sumOfSquares = SumOfSquares.Arrays(array);

            Console.WriteLine($"Soma dos quadrados dos elementos do referido array: {sumOfSquares}");
        }
    }
}