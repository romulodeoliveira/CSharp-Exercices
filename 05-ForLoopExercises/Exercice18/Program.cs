/*
Escreva um programa em C# Sharp para encontrar a soma da série [ 1-X^2/2!+X^4/4!- .........].
Dados de teste:
Insira o valor de x: 2
Insira o número de termos: 5
Saída esperada :
a soma = -0,415873
Número de termos = 5
valor de x = 2,000000
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de termos: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        double sum = CalculateSumOfSeries(x, numberOfTerms);

        Console.WriteLine($"A soma = {sum:F6}");
        Console.WriteLine($"Número de termos = {numberOfTerms}");
        Console.WriteLine($"Valor de x = {x:F6}");

        Console.ReadLine();
    }

    static double CalculateSumOfSeries(double x, int numberOfTerms)
    {
        double sum = 1.0;
        double term = 1.0;

        for (int i = 1; i < numberOfTerms; i++)
        {
            term *= -1 * (x * x) / ((2 * i) * (2 * i + 1));
            sum += term;
        }

        return sum;
    }
}
