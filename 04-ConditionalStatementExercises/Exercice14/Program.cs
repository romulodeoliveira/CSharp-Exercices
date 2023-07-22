using System;

/*
Escreva um programa C# Sharp para verificar se um triângulo é Equilátero, Isósceles ou Escaleno.

Dados de teste:
50 50 60

Saída esperada :
Este é um triângulo isósceles.
*/

namespace Exercice14;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite os três lados do triângulo (separados por espaço): ");

        string input = Console.ReadLine();
        string[] sides = input.Split(' ');

        if (sides.Length != 3)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira três valores separados por espaço.");
            return;
        }

        double side1, side2, side3;
        if (!double.TryParse(sides[0], out side1) || !double.TryParse(sides[1], out side2) || !double.TryParse(sides[2], out side3))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira apenas valores numéricos válidos.");
            return;
        }

        string triangleType;

        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilátero";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            triangleType = "Isósceles";
        }
        else
        {
            triangleType = "Escaleno";
        }

        Console.WriteLine($"Este é um triângulo {triangleType}.");
    }
}
