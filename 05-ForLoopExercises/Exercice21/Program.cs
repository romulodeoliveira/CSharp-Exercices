/*
Escreva um programa em C# Sharp para exibir a soma da série [ 9 + 99 + 999 + 9999 ...].
Dados de teste:
Insira o número ou termos: 5
Saída esperada :
9 99 999 9999 99999
A soma da série = 111105
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de termos: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        DisplaySeriesTerms(numberOfTerms);

        long seriesSum = CalculateSeriesSum(numberOfTerms);

        Console.WriteLine($"A soma da série = {seriesSum}");

        Console.ReadLine();
    }

    static void DisplaySeriesTerms(int n)
    {
        Console.Write("Termos da Série: ");

        for (int i = 1; i <= n; i++)
        {
            long term = int.Parse(new string('9', i));
            Console.Write($"{term} ");

            if (i < n)
            {
                Console.Write("+ ");
            }
        }

        Console.WriteLine();
    }

    static long CalculateSeriesSum(int n)
    {
        long sum = 0;

        for (int i = 1; i <= n; i++)
        {
            long term = long.Parse(new string('9', i));
            sum += term;
        }

        return sum;
    }
}
