/*
Escreva um C# Sharp Program para exibir o seguinte padrão usando o alfabeto.

A
ABA
ABCBA
ABCDCBA
*/

using System;

class Program
{
    static void Main()
    {
        char startChar = 'A';
        char endChar;

        Console.Write("Insira o último caractere (em maiúscula): ");
        endChar = char.Parse(Console.ReadLine());

        PrintAlphabetPattern(startChar, endChar);

        Console.ReadLine();
    }

    static void PrintAlphabetPattern(char startChar, char endChar)
    {
        for (char i = startChar; i <= endChar; i++)
        {
            for (char j = startChar; j <= i; j++)
            {
                Console.Write(j);
            }

            for (char j = (char)(i - 1); j >= startChar; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}
