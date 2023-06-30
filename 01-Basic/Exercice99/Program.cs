using System;

/*
Escreva um programa C# Sharp para criar e exibir todos os números primos em ordem de dígitos decimais estritamente ascendente.

Sample Data:
2, 3, 5, 7, 13, 17, 19, 23, 29, 37, 47, 59, 67, 79,
*/

namespace Exercice99;

class Program
{
    static void Main(string[] args)
    {
        List<int> primeNumbers = new List<int>();

        int limit = 1000;
        for (int i = 2; i <= limit; i++)
        {
            if (Number.IsPrime(i))
            {
                primeNumbers.Add(i);
            }
        }

        primeNumbers.Sort();

        Console.WriteLine("Números primos em ordem ascendente:");
        foreach (int prime in primeNumbers)
        {
            Console.Write(prime + ", ");
        }

        Console.WriteLine();
    }
}