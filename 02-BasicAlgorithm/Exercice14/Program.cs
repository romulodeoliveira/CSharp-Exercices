using System;

/*
Escreva um programa C# Sharp para verificar se dois inteiros fornecidos estão no intervalo de 100 a 200, inclusive.

Entrada de amostra:
100, 199
250, 300
105, 190

Saída esperada:
Verdadeiro
Falso
Verdadeiro
*/

namespace Exercice14;

class Program
{
    static void Main(string[] args)
    {
        int[] values1 = new int[] { 100, 199 };
        int[] values2 = new int[] { 250, 300 };
        int[] values3 = new int[] { 105, 190 };

        bool result1 = values1[0] >= 100 && values1[0] <= 200 && values1[1] >= 100 && values1[1] <= 200;
        bool result2 = values2[0] >= 100 && values2[0] <= 200 && values2[1] >= 100 && values2[1] <= 200;
        bool result3 = values3[0] >= 100 && values3[0] <= 200 && values3[1] >= 100 && values3[1] <= 200;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}