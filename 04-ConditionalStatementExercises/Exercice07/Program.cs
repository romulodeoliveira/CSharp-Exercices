using System;

/*
Escreva um programa C# Sharp para aceitar a altura de uma pessoa em centímetros e categorizá-la de acordo com sua altura.

Dados de teste: 135

Saída esperada :
A pessoa é Anão.
*/

namespace Exercice07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a altura em centímetros: ");
        int altura = int.Parse(Console.ReadLine());

        string categoria;

        if (altura < 150)
        {
            categoria = "Anão";
        }
        else if (altura < 165)
        {
            categoria = "Baixo";
        }
        else if (altura < 180)
        {
            categoria = "Médio";
        }
        else if (altura < 195)
        {
            categoria = "Alto";
        }
        else
        {
            categoria = "Muito Alto";
        }

        Console.WriteLine($"A pessoa é {categoria}.");
    }
}
