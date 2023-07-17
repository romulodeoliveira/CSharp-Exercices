using System;

/*
Escreva um programa C# Sharp para aceitar um ponto de coordenada em um sistema de coordenadas XY e determinar em qual quadrante o ponto de coordenada está.

Dados de teste:
Insira o valor para a coordenada X:7
Insira o valor para a coordenada Y:9

Saída esperada :
O ponto de coordenada (7,9) está no primeiro quadrante.
*/

namespace Exercice09;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o valor para a coordenada X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Insira o valor para a coordenada Y: ");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está no primeiro quadrante.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está no segundo quadrante.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está no terceiro quadrante.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está no quarto quadrante.");
        }
        else if (x == 0 && y != 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está sobre o eixo Y.");
        }
        else if (x != 0 && y == 0)
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está sobre o eixo X.");
        }
        else
        {
            Console.WriteLine($"O ponto de coordenada ({x},{y}) está na origem.");
        }
    }
}
