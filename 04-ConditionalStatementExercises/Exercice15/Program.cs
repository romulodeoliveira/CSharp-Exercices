using System;

/*
Escreva um programa C# Sharp para verificar se um triângulo pode ser formado pelo valor dado para os ângulos.

Dados de teste:
40 55 65

Saída esperada :
O triângulo não é válido.
*/

namespace Exercice15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite os três valores dos ângulos do triângulo (separados por espaço):");

        string input = Console.ReadLine();
        string[] angles = input.Split(' ');

        if (angles.Length != 3)
        {
            Console.WriteLine("Entrada inválida. Por favor, insira três valores separados por espaço.");
            return;
        }

        double angle1, angle2, angle3;
        if (!double.TryParse(angles[0], out angle1) || !double.TryParse(angles[1], out angle2) || !double.TryParse(angles[2], out angle3))
        {
            Console.WriteLine("Entrada inválida. Por favor, insira apenas valores numéricos válidos.");
            return;
        }

        if (angle1 + angle2 + angle3 == 180)
        {
            Console.WriteLine("O triângulo é válido.");
        }
        else
        {
            Console.WriteLine("O triângulo não é válido.");
        }
    }
}
