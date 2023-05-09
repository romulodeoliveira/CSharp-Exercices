using System;

// Escreva um programa C# Sharp para encontrar o valor mínimo de dois números dados, representados como string.

namespace Exercice65
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro número: ");
            string str1 = Console.ReadLine();

            System.Console.Write("Digite o segundo número: ");
            string str2 = Console.ReadLine();

            if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2))
            {
                System.Console.WriteLine($"Menor valor: {Math.Min(num1, num2)}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas numeros inteiros.");
            }
        }
    }
}