using System;

/*
Escreva um programa C# Sharp para verificar se dois números inteiros não negativos fornecidos têm o mesmo último dígito.

Entrada de amostra :
123, 456
12, 512
7, 87
12, 45

Saída esperada :
Falso
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice23;

class Program
{
    static void Main(string[] args)
    {
        int[][] nums = new int[][]
        {
            new int[] { 123, 456 },
            new int[] { 12, 512 },
            new int[] { 7, 87 },
            new int[] { 12, 45 },
        };

        bool sameLastDigit1 = HaveSameLastDigit(nums[0][0], nums[0][1]);
        bool sameLastDigit2 = HaveSameLastDigit(nums[1][0], nums[1][1]);
        bool sameLastDigit3 = HaveSameLastDigit(nums[2][0], nums[2][1]);
        bool sameLastDigit4 = HaveSameLastDigit(nums[3][0], nums[3][1]);
        
        Console.WriteLine(sameLastDigit1 ? "Verdadeiro" : "Falso");
        Console.WriteLine(sameLastDigit2 ? "Verdadeiro" : "Falso");
        Console.WriteLine(sameLastDigit3 ? "Verdadeiro" : "Falso");
        Console.WriteLine(sameLastDigit4 ? "Verdadeiro" : "Falso");
    }
    
    static bool HaveSameLastDigit(int num1, int num2)
    {
        int lastDigit1 = num1 % 10;
        int lastDigit2 = num2 % 10;
        
        return lastDigit1 == lastDigit2;
    }
}
