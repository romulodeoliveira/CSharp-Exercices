using System;

/*
Escreva um programa em C# Sharp para ler qualquer dígito, exiba na palavra.

Dados de teste:
4

Saída esperada :
Quatro
*/

namespace Exercice21;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um dígito: ");
        int digit = int.Parse(Console.ReadLine());

        string wordRepresentation = GetWordRepresentation(digit);

        Console.WriteLine($"O dígito em representação por extenso é: {wordRepresentation}");
    }

    static string GetWordRepresentation(int digit)
    {
        switch (digit)
        {
            case 0:
                return "Zero";
            case 1:
                return "Um";
            case 2:
                return "Dois";
            case 3:
                return "Três";
            case 4:
                return "Quatro";
            case 5:
                return "Cinco";
            case 6:
                return "Seis";
            case 7:
                return "Sete";
            case 8:
                return "Oito";
            case 9:
                return "Nove";
            default:
                return "Dígito inválido";
        }
    }
}
