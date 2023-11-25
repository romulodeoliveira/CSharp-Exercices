/*
Escreva um programa em C# Sharp para converter um número octal em decimal sem usar um array.
Dados de teste:
Insira um número octal (usando o dígito 0 - 7) :745
Saída esperada :
O número octal: 745
O número decimal equivalente: 485
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string octalNumber = Console.ReadLine();

        int decimalNumber = 0;
        for (int i = octalNumber.Length - 1; i >= 0; i--)
        {
            decimalNumber += (octalNumber[i] - '0') * (int)Math.Pow(8, octalNumber.Length - 1 - i);
        }

        Console.WriteLine($"O número octal: {octalNumber}");
        Console.WriteLine($"O número decimal equivalente: {decimalNumber}");
    }
}
