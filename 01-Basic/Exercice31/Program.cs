using System;

/*
Escreva um programa C# para multiplicar elementos correspondentes de duas matrizes de inteiros.

Exemplo de saída:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiplique os elementos correspondentes de dois arrays:
1 12 25 -8
*/

namespace Exercice31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[4] { 1, 3, -5, 4 };
            int[] secondArray = new int[4] { 1, 4, -5, 2 };

            System.Console.WriteLine($"|| {firstArray[0] * secondArray[0]} || {firstArray[1] * secondArray[1]} || {firstArray[2] * secondArray[2]} || {firstArray[3] * secondArray[3]} ||");
        }
    }
}