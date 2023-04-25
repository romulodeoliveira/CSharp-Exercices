using System;

// Escreva um programa C# Sharp para imprimir o resultado das operações especificadas.
// Dados de teste:

/*
-1 + 4 * 6
(35 + 5) % 7
14 + -4 * 6 / 11
2 + 15 / 6 * 1 - 7 % 2
*/

namespace Excercice04
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Operação 01
            // -1 + 4 * 6

            System.Console.WriteLine($"O resultado da primeira operação é: {-1 + 4 * 6}");

            // Operação 02
            // (35 + 5) % 7

            System.Console.WriteLine($"O resultado da segunda operação é: {(35 + 5) % 7}");

            // Operação 03
            // 14 + -4 * 6 / 11

            System.Console.WriteLine($"O resultado da terceira operação é: {14 + -4 * 6 / 11}");

            // Operação 04
            // 2 + 15 / 6 * 1 - 7 % 2

            System.Console.WriteLine($"O resultado da terceira operação é: {2 + 15 / 6 * 1 - 7 % 2}");

        }
    }
}