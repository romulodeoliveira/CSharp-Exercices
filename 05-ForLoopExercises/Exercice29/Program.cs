/*
Escreva um programa C# Sharp para verificar se um determinado número é um número de Armstrong ou não.
Dados de teste:
Insira um número: 153
Saída esperada :
153 é um número de Armstrong.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número: ");
        int number = int.Parse(Console.ReadLine());

        if (IsArmstrongNumber(number))
        {
            Console.WriteLine($"{number} é um número de Armstrong.");
        }
        else
        {
            Console.WriteLine($"{number} não é um número de Armstrong.");
        }

        Console.ReadLine();
    }

    static bool IsArmstrongNumber(int num)
    {
        int originalNumber = num;
        int result = 0;
        int n = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            result += (int)Math.Pow(digit, n);
            num /= 10;
        }

        return result == originalNumber;
    }
}
