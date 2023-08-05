using System;

/*
Escreva um programa C# Sharp que tome o raio de um círculo como entrada e calcule o perímetro e a área do círculo.

Dados de teste
Insira o raio do círculo:
12
Saída esperada :
Perímetro do círculo: 75,36
*/

namespace Exercice05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o raio do círculo: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine($"Perímetro do círculo: {perimeter.ToString("F2")}");
    }
}