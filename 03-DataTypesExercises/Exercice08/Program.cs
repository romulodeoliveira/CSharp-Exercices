using System;

/*
Escreva um programa C# Sharp que tome o raio de uma esfera como entrada e calcule e exiba a superfície e o volume da esfera.

Dados de teste:
Raio: 2
Saída esperada:
50,26548
33,51032
*/

namespace Exercice08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Raio: ");
        double radius = double.Parse(Console.ReadLine());

        double surfaceArea = 4 * Math.PI * radius * radius;
        double volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);

        Console.WriteLine(surfaceArea.ToString("F5"));
        Console.WriteLine(volume.ToString("F5"));
    }
}
