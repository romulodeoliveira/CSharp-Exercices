using System;

/*
Escreva um programa em C# Sharp para verificar se uma determinada temperatura é menor que 0 e a outra é maior que 100.

Entrada de amostra :
120, -1
-1, 120
2, 120

Saída esperada :
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice13;

class Program
{
    static void Main(string[] args)
    {
        int[] temperature1 = new int[] { 120, -1 };
        int[] temperature2 = new int[] { -1, 120 };
        int[] temperature3 = new int[] { 2, 120 };

        bool result1 = temperature1[0] < 0 && temperature1[1] > 100 || temperature1[0] > 0 && temperature1[1] < 100;
        bool result2 = temperature2[0] < 0 && temperature2[1] > 100 || temperature2[0] > 0 && temperature2[1] < 100;
        bool result3 = temperature3[0] < 0 && temperature3[1] > 100 || temperature3[0] < 0 && temperature3[1] > 100;

        Console.WriteLine(result1);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }
}