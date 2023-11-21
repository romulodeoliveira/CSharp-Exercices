/*
Escreva um programa C# Sharp para verificar se um número é um número forte ou não.
Dados de teste:
insira um número para verificar se é um número forte: 15
Saída esperada :
15 não é um número forte.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número para verificar se é um número forte: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsStrongNumber(number))
        {
            Console.WriteLine($"{number} é um número forte.");
        }
        else
        {
            Console.WriteLine($"{number} não é um número forte.");
        }

        Console.ReadLine();
    }

    static bool IsStrongNumber(int n)
    {
        int originalNumber = n;
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += Factorial(digit);
            n /= 10;
        }

        return sum == originalNumber;
    }

    static int Factorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }

        return num * Factorial(num - 1);
    }
}
