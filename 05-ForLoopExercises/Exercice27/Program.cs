/*
Escreva um programa C# Sharp para verificar se um número é um número perfeito.
Dados de teste:
Insira o número: 56
Saída esperada :
O divisor positivo: 1 2 4 7 8 14 28
A soma do divisor é: 64
Portanto, o número não é perfeito.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        DisplayDivisors(number);

        bool isPerfect = CheckPerfectNumber(number);

        if (isPerfect)
        {
            Console.WriteLine("Portanto, o número é perfeito.");
        }
        else
        {
            Console.WriteLine("Portanto, o número não é perfeito.");
        }

        Console.ReadLine();
    }

    static void DisplayDivisors(int n)
    {
        Console.Write("Os divisores positivos são: ");

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }

    static bool CheckPerfectNumber(int n)
    {
        int sum = 0;

        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }

        return sum == n;
    }
}
