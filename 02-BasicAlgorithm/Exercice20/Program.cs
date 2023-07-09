using System;

/*
Escreva um programa C# Sharp para verificar se dois números inteiros fornecidos estão no intervalo de 40 a 50, inclusive, ou se ambos estão no intervalo de 50 a 60, inclusive.

Entrada de amostra :
78, 95
25, 35
40, 50
55, 60

Saída esperada :
Falso
Falso
Verdadeiro
Verdadeiro
*/

namespace Exercice20;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckNumberRanges(78, 95));
        Console.WriteLine(CheckNumberRanges(25, 35));
        Console.WriteLine(CheckNumberRanges(40, 50));
        Console.WriteLine(CheckNumberRanges(55, 60));
    }

    static bool CheckNumberRanges(int number1, int number2)
    {
        bool range1 = (number1 >= 40 && number1 <= 50) && (number2 >= 40 && number2 <= 50);
        bool range2 = (number1 >= 50 && number1 <= 60) && (number2 >= 50 && number2 <= 60);

        return range1 || range2;
    }
}
