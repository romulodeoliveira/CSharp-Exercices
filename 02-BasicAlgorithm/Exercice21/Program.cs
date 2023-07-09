using System;

/*
Escreva um programa C# Sharp para encontrar o maior valor de dois valores inteiros positivos que estejam no intervalo de 20 a 30, inclusive, ou retorne 0 se nenhum estiver nesse intervalo.

Entrada de amostra :
78, 95
20, 30
21, 25
28, 28

Saída esperada :
0
30
25
28
*/

namespace Exercice21;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindLargestInRange(78, 95));
        Console.WriteLine(FindLargestInRange(20, 30));
        Console.WriteLine(FindLargestInRange(21, 25));
        Console.WriteLine(FindLargestInRange(28, 28));
    }

    static int FindLargestInRange(int number1, int number2)
    {
        bool inRange1 = number1 >= 20 && number1 <= 30;
        bool inRange2 = number2 >= 20 && number2 <= 30;

        if (!inRange1 && !inRange2)
        {
            return 0;
        }
        else if (inRange1 && inRange2)
        {
            return Math.Max(number1, number2);
        }
        else if (inRange1)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }
}
