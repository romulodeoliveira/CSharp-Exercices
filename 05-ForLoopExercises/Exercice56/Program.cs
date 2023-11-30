/*
Escreva um programa em C# Sharp para verificar se um número pode ser expresso como a soma de dois números primos.
Dados de teste:
Insira um número inteiro positivo: 16
Saída esperada :
16 = 3 + 13
16 = 5 + 11
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número inteiro positivo: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 != 0 || num <= 2)
        {
            Console.WriteLine("O número deve ser um inteiro positivo par maior que 2.");
        }
        else
        {
            FindPrimePairs(num);
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void FindPrimePairs(int num)
    {
        Console.WriteLine($"Possíveis pares de números primos cuja soma é {num}:");

        for (int i = 2; i <= num / 2; i++)
        {
            if (IsPrime(i) && IsPrime(num - i))
            {
                Console.WriteLine($"{num} = {i} + {num - i}");
            }
        }
    }
}
