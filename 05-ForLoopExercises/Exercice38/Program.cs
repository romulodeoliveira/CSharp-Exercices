/*
Escreva um programa em C# Sharp para verificar se um número é um palíndromo ou não.
Dados de teste:
Insira um número: 121
Saída esperada :
121 é um número palíndromo.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} é um número palíndromo.");
        }
        else
        {
            Console.WriteLine($"{number} não é um número palíndromo.");
        }

        Console.ReadLine();
    }

    static bool IsPalindrome(int num)
    {
        int originalNumber = num;
        int reversedNumber = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            num /= 10;
        }

        return originalNumber == reversedNumber;
    }
}
