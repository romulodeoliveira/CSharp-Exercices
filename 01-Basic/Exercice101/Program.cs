using System;

/*
Escreva um programa C# Sharp para calcular o valor de e.

Nota: e também é conhecido como número de Euler e constante de Napier
Dados de amostra:
e = 2,718281828459050
*/

namespace Exercice101;

class Program
{
    static void Main(string[] args)
    {
        double e = CalculateE();
        Console.WriteLine($"O valor de e é: {e}");
    }

    static double CalculateE()
    {
        double e = 1.0;
        double factorial = 1.0;

        for (int i = 1; i <= 10; i++)
        {
            factorial *= i;
            e += 1.0 / factorial;
        }

        return e;
    }
}
