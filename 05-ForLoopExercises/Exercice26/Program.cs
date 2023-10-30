/*
Escreva um programa em C# Sharp para encontrar a soma da série 1 +11 + 111 + 1111 + .. n termos.
Dados de teste:
Insira o número de termos: 5
Saída esperada :
1 + 11 + 111 + 1111 + 11111 +
A soma é: 12345
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de termos: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        DisplaySeriesTerms(numberOfTerms);

        int sum = CalculateSeriesSum(numberOfTerms);

        Console.WriteLine($"A soma é: {sum}");

        Console.ReadLine();
    }

    static void DisplaySeriesTerms(int n)
    {
        Console.Write("Série: ");

        int term = 0;

        for (int i = 1; i <= n; i++)
        {
            term = term * 10 + 1;
            Console.Write($"{term}");

            if (i < n)
            {
                Console.Write(" + ");
            }
        }

        Console.WriteLine();
    }

    static int CalculateSeriesSum(int n)
    {
        int sum = 0;
        int term = 0;

        for (int i = 1; i <= n; i++)
        {
            term = term * 10 + 1;
            sum += term;
        }

        return sum;
    }
}
