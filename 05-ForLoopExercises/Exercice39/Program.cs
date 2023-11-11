/*
Escreva um programa C# Sharp para encontrar o número e a soma de todos os inteiros entre 100 e 200 divisíveis por 9.
Saída esperada :
Números entre 100 e 200, divisíveis por 9:
108 117 126 135 144 153 162 171 180 189 198
A soma : 1683
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números entre 100 e 200, divisíveis por 9:");

        int sum = 0;

        for (int i = 100; i <= 200; i++)
        {
            if (i % 9 == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }

        Console.WriteLine($"\nA soma: {sum}");

        Console.ReadLine();
    }
}
