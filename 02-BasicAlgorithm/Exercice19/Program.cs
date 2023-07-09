using System;

/*
Escreva um programa C# Sharp para verificar qual número está mais próximo do valor 100 entre dois inteiros fornecidos. Retorne 0 se os dois números forem iguais.

Entrada de amostra :
78, 95
95, 95
99, 70

Saída esperada :
95
0
99
*/

namespace Exercice19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetClosestTo100(78, 95));
        Console.WriteLine(GetClosestTo100(95, 95));
        Console.WriteLine(GetClosestTo100(99, 70));
    }

    static int GetClosestTo100(int number1, int number2)
    {
        int difference1 = Math.Abs(100 - number1);
        int difference2 = Math.Abs(100 - number2);

        if (difference1 == difference2)
        {
            return 0;
        }
        else if (difference1 < difference2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }
}