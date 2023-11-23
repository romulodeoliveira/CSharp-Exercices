/*
Escreva um programa C# Sharp para descobrir a soma da série de Progresso Aritmético.
Dados de teste:
Insira o número inicial da série AP: 1
Insira o número de itens para a série AP: 10
Insira a diferença comum da série AP: 4
Saída esperada :
A soma da série AP é:
1 + 5 + 9 + 13 + 17 + 21 + 25 + 29 + 33 + 37 = 190
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int firstTerm = int.Parse(args[0]);
        int numberOfTerms = int.Parse(args[1]);
        int commonDifference = int.Parse(args[2]);

        int sum = (firstTerm + lastTerm(firstTerm, numberOfTerms, commonDifference)) / 2;

        Console.WriteLine($"A soma da série AP é:");
        for (int i = 0; i < numberOfTerms; i++)
        {
            Console.Write($" {firstTerm + i * commonDifference}");
        }
        Console.WriteLine(" = {sum}");
    }

    private static int lastTerm(int firstTerm, int numberOfTerms, int commonDifference)
    {
        return firstTerm + (numberOfTerms - 1) * commonDifference;
    }
}
