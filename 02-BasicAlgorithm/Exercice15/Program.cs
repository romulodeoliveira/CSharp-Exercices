using System;

/*
Escreva um programa C# Sharp para verificar se três valores inteiros fornecidos estão no intervalo de 20 a 50 inclusive. Retorna verdadeiro se 1 ou mais deles estiverem no referido intervalo, caso contrário, falso.

Entrada de amostra :
11, 20, 12
30, 30, 17
25, 35, 50
15, 12, 8

Saída esperada :
Verdadeiro
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice15;

class Program
{
    static void Main(string[] args)
    {
        int[] values1 = new int[] { 11, 20, 12 };
        int[] values2 = new int[] { 30, 30, 17 };
        int[] values3 = new int[] { 25, 35, 50 };
        int[] values4 = new int[] { 15, 12, 8 };

        bool result1 = values1[0] >= 20 && values1[0] <= 50 || values1[1] >= 20 && values1[1] <= 50 || values1[2] >= 20 && values1[2] <= 50;
        bool result2 = values2[0] >= 20 && values2[0] <= 50 || values2[1] >= 20 && values2[1] <= 50 || values2[2] >= 20 && values2[2] <= 50;
        bool result3 = values3[0] >= 20 && values3[0] <= 50 || values3[1] >= 20 && values3[1] <= 50 || values3[2] >= 20 && values3[2] <= 50;
        bool result4 = values4[0] >= 20 && values4[0] <= 50 || values4[1] >= 20 && values4[1] <= 50 || values4[2] >= 20 && values4[2] <= 50;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);   
        Console.WriteLine(result4);   
    }
}