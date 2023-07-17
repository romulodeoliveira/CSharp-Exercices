using System;

/*
Escreva um programa C# Sharp para encontrar o maior de três números.

Dados de teste:
Insira o 1º número: 25
Insira o 2º número: 63
Insira o 3º número: 10

Saída esperada :
O 2º número é o maior entre três
*/

namespace Exercice08;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o 1º número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Insira o 2º número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Insira o 3º número: ");
        int num3 = int.Parse(Console.ReadLine());

        int maior = 0;
        
        if (num1 > num2 && num1 > num3)
        {
            maior = 1;
        }

        else if (num2 > num3)
        {
            maior = 2;
        }

        else
        {
            maior = 3;
        }

        Console.WriteLine($"O {maior}º número é o maior entre os três.");
    }
}
