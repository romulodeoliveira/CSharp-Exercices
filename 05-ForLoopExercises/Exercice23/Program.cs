/*
Escreva um programa em C# Sharp para exibir a soma da série [ 1+x+x^2/2!+x^3/3!+....].
Dados de teste:
Insira o valor de x:3
Insira o número de termos: 5
Saída esperada :
A soma é: 16,375000
Número de termos = 5
O valor de x = 3,000000
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

        Console.WriteLine($"A soma é: {sum:F6}");
        Console.WriteLine($"Número de termos = {numberOfTerms}");
        Console.WriteLine($"O valor de x = {x:F6}");

        Console.ReadLine();
    }

    static double CalculateSeriesSum(double x, int n)
    {
        double sum = 1.0;
        double term = 1.0;

        for (int i = 1; i < n; i++)
        {
            term *= x / i;
            sum += term;
        }

        return sum;
    }
}
