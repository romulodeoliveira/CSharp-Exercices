using System;

/*
Escreva um programa C# Sharp para criar e exibir todos os números primos em ordem estritamente decrescente de dígitos decimais.

Sample Data:
2, 3, 5, 7, 31, 41, 43, 53, 61, 71, 73, 83, 97, 421, 431...
*/

namespace Exercice98;

public class Program
{
    public static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Números primos em ordem decrescente:");

        for (int i = 1000; i >= 2; i--)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }
}
