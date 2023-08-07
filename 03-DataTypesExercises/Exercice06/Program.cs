using System;

// Escreva um programa C# Sharp para exibir certos valores da função x = y 2 + 2y + 1 (usando números inteiros para y , variando de -5 a +5).

namespace Exercice06;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valores da função x = y^2 + 2y + 1:");

        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;
            Console.WriteLine($"y = {y}, x = {x}");
        }
    }
}