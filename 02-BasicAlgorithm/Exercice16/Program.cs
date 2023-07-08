using System;

/*
Escreva um programa C# Sharp para verificar se dois valores inteiros fornecidos estão no intervalo de 20 a 50 inclusive. Retorna verdadeiro se 1 ou outro estiver no referido intervalo, caso contrário, falso.

Entrada de amostra :
20, 84
14, 50
11, 45
25, 40

Saída esperada :
Verdadeiro
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice16;

class Program
{
    static void Main(string[] args)
    {
        int[] values1 = new int[] { 20, 84 };
        int[] values2 = new int[] { 14, 50 };
        int[] values3 = new int[] { 11, 45 };
        int[] values4 = new int[] { 25, 40 };

        bool result1 = values1[0] >= 20 && values1[0] <= 50 && values1[1] < 20 || values1[1] > 50 || values1[1] >= 20 && values1[1] <= 50 && values1[0] < 20 || values1[0] > 50;
        bool result2 = values2[0] >= 20 && values2[0] <= 50 && values2[1] < 20 || values2[1] > 50 || values2[1] >= 20 && values2[1] <= 50 && values2[0] < 20 || values2[0] > 50;
        bool result3 = values3[0] >= 20 && values3[0] <= 50 && values3[1] < 20 || values3[1] > 50 || values3[1] >= 20 && values3[1] <= 50 && values3[0] < 20 || values3[0] > 50;
        bool result4 = values4[0] >= 20 && values4[0] <= 50 && values4[1] < 20 || values4[1] > 50 || values4[1] >= 20 && values4[1] <= 50 && values4[0] < 20 || values4[0] > 50;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);   
        Console.WriteLine(result4);   
    }
}