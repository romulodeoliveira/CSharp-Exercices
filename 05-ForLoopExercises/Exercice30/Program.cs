/*
Escreva um programa C# Sharp para encontrar o número de Armstrong para um determinado intervalo de números.
Dados de teste:
Insira o número inicial do intervalo: 1
Insira o número final do intervalo: 1000
Saída esperada :
Os números de Armstrong em determinado intervalo são: 1 153 370 371 407
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número inicial do intervalo: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Insira o número final do intervalo: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Os números de Armstrong no intervalo fornecido são:");

        for (int num = start; num <= end; num++)
        {
            if (IsArmstrongNumber(num))
            {
                Console.Write(num + " ");
            }
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
