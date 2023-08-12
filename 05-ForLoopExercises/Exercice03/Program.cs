using System;

/*
Escreva um programa C# Sharp que exiba a soma de n números naturais.
Dados de teste: 7
Saída esperada :
Os primeiros 7 números naturais são:
1 2 3 4 5 6 7
A soma do número natural até 7 termos: 28
*/

namespace Exercice03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número natural: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine($"Os primeiros {n} números naturais são:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }

        Console.WriteLine($"\nA soma dos números naturais até {n} termos: {sum}");
    }
}