/*
Escreva um programa C# Sharp que exiba os n termos de números naturais quadrados e sua soma.
1 4 9 16 ... n Termos
Dados de teste:
Insira o número de termos: 5
Saída esperada :
O quadrado natural até 5 termos é: 1 4 9 16 25
A soma do quadrado do número natural até 5 termos = 55
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de termos: ");
        int numberOfTerms = Convert.ToInt32(Console.ReadLine());

        DisplayNaturalSquares(numberOfTerms);

        int sum = CalculateSquareSum(numberOfTerms);

        Console.WriteLine($"A soma do quadrado do número natural até {numberOfTerms} termos = {sum}");

        Console.ReadLine();
    }

    static void DisplayNaturalSquares(int n)
    {
        Console.Write("O quadrado natural até {0} termos é: ", n);

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"{i * i} ");
        }

        Console.WriteLine();
    }

    static int CalculateSquareSum(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i * i;
        }

        return sum;
    }
}
