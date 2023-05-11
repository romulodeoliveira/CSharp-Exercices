using System;

// Escreva um programa C# Sharp para contar um caractere especificado (ambos os casos) em uma determinada string.

namespace Exercice68
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Olá, Mundo!";
            int count = str.Count(c => c == 'o');
            System.Console.WriteLine(count);
        }
    }
}