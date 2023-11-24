/*
Escreva um programa em C# Sharp para converter um número decimal em octal sem usar um array.
Dados de teste:
Digite um número para converter: 79
Saída esperada :
O Octal de 79 é 117.
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        string octalNumber = "";
        while (decimalNumber != 0)
        {
            octalNumber += (decimalNumber % 8);
            decimalNumber /= 8;
        }

        Console.WriteLine($"O Octal de {decimalNumber} é {octalNumber}");
    }
}
