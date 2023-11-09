/*
Escreva um programa em C# Sharp para exibir um número na ordem inversa.
Dados de teste:
Insira um número: 12345
Saída esperada :
O número na ordem inversa é: 54321
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"O número na ordem inversa é: {reversedNumber}");

        Console.ReadLine();
    }

    static int ReverseNumber(int num)
    {
        int reversedNumber = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversedNumber = (reversedNumber * 10) + digit;
            num /= 10;
        }

        return reversedNumber;
    }
}
