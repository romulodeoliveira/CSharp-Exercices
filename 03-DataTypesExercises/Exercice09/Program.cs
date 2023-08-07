using System;

/*
Escreva um programa C# Sharp que receba um caractere como entrada e verifique se a entrada (minúscula) é uma vogal, um dígito ou qualquer outro símbolo.

Dados de teste:
Insira um símbolo: a
Saída esperada:
É uma vogal minúscula.
*/

namespace Exercice09;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um símbolo: ");
        char symbol = char.Parse(Console.ReadLine());

        if (Char.IsDigit(symbol))
        {
            Console.WriteLine("É um dígito.");
        }
        else if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
        {
            Console.WriteLine("É uma vogal minúscula.");
        }
        else
        {
            Console.WriteLine("É qualquer outro símbolo.");
        }
    }
}
