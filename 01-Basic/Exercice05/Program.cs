using System;

/*
Escreva um programa C# Sharp para trocar dois números.

Dados de teste:
Insira o primeiro número: 5
Insira o segundo número: 6

Saída esperada após a troca:
Primeiro número: 6
Segundo número: 5
*/

namespace Exercice05
{
    class Program
    {
        public static void Main(string[] args)
        {

            System.Console.Write("Insira o primeiro número: ");
            string a = Console.ReadLine();

            System.Console.Write("Insira o segundo número: ");
            string b = Console.ReadLine();

            if (int.TryParse(a, out int c) && int.TryParse(b, out int d))
            {
                int temporary = c;
                c = d;
                d = temporary;

                System.Console.WriteLine($"Primeiro número: {c}");
                System.Console.WriteLine($"Segundo número: {d}");
            }
            else
            {
                System.Console.WriteLine("Entrada inválida. Por favor digite um número inteiro.");
            }
        }
    }
}