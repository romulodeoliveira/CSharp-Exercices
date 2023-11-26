/*
Escreva um programa C# Sharp para encontrar a soma da série Progresso Geométrico.
Dados de teste:
Insira o primeiro número da série GP: 1
Insira o número ou termos na série GP: 5
Insira a razão comum da série GP: 2
Saída esperada :
Os números para a série GP:
1 2 4 8 16 32
O tn termos de GP : 16.000000
A Soma da série GP : 63.000000
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        double firstTerm = double.Parse(args[0]);
        int numberOfTerms = int.Parse(args[1]);
        double commonRatio = double.Parse(args[2]);

        double[] terms = new double[numberOfTerms];
        for (int i = 0; i < numberOfTerms; i++)
        {
            terms[i] = firstTerm * Math.Pow(commonRatio, i);
        }

        Console.WriteLine("Os números para a série GP:");
        for (int i = 0; i < numberOfTerms; i++)
        {
            Console.WriteLine(terms[i]);
        }

        double tn = terms[numberOfTerms - 1];

        double sum = 0;
        for (int i = 0; i < numberOfTerms; i++)
        {
            sum += terms[i] / (1 - commonRatio);
        }

        Console.WriteLine("O tn termos de GP: {0:0.000000}", tn);
        Console.WriteLine("A Soma da série GP: {0:0.000000}", sum);
    }
}
