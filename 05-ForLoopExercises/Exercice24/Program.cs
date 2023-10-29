/*
Escreva um programa em C# Sharp para encontrar a soma da série [ x - x^3 + x^5 - x^7 + x^9 -.....].
Dados de teste:
Insira o valor de x: 2
Insira o número de termos: 5
A soma = 410
Número de termos = 5
O valor de x = 2
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o número de termos: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        double sum = CalculateSeriesSum(x, numberOfTerms);

        Console.WriteLine($"A soma = {sum}");
        Console.WriteLine($"Número de termos = {numberOfTerms}");
        Console.WriteLine($"O valor de x = {x}");

        Console.ReadLine();
    }

    static double CalculateSeriesSum(double x, int n)
    {
        double sum = 0;
        int power = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(x, power) * (i % 2 == 1 ? 1 : -1);
            power += 2;
        }

        return sum;
    }
}
