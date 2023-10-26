/*
Escreva um programa em C# Sharp para exibir os n termos da série harmônica e sua soma.
1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n termos
Dados de teste:
Insira o número de termos: 5
Saída esperada :
1/1 + 1/2 + 1/3 + 1 /4 + 1/5 +
Soma de Séries até 5 termos : 2.283334
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        DisplayHarmonicSeries(numberOfTerms);

        double sum = CalculateSumHarmonicSeries(numberOfTerms);

        Console.WriteLine($"Soma de Séries até {numberOfTerms} termos: {sum:F6}");

        Console.ReadLine();
    }

    static void DisplayHarmonicSeries(int n)
    {
        Console.Write("Série Harmônica: ");
        double term = 0.0;

        for (int i = 1; i <= n; i++)
        {
            term = 1.0 / i;
            Console.Write($"{term:F5} ");

            if (i < n)
            {
                Console.Write("+ ");
            }
        }

        Console.WriteLine();
    }

    static double CalculateSumHarmonicSeries(int n)
    {
        double sum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
        }

        return sum;
    }
}
