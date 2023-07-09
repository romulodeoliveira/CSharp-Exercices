using System;

/*
Escreva um programa C# Sharp para verificar o maior número entre três inteiros dados.

Entrada de amostra :
1,2,3
1,3,2
1,1,1
1,2,2

Saída esperada :
3
3
1
2
*/

namespace Exercice18;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetLargestNumber(1, 2, 3));
        Console.WriteLine(GetLargestNumber(1, 3, 2));
        Console.WriteLine(GetLargestNumber(1, 1, 1));
        Console.WriteLine(GetLargestNumber(1, 2, 2));
    }

    static int GetLargestNumber(int number1, int number2, int number3)
    {
        int largest = number1;

        if (number2 > largest)
        {
            largest = number2;
        }

        if (number3 > largest)
        {
            largest = number3;
        }

        return largest;
    }
}