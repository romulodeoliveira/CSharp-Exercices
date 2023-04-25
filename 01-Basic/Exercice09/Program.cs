using System;

/*
Escreva um programa C# Sharp que receba quatro números como entrada para calcular e imprimir a média.

Dados de teste:
Digite o primeiro número: 10
Digite o segundo número: 15
Digite o terceiro número: 20
Digite os quatro números: 30

Saída esperada:
A média de 10 , 15 , 20 , 30 é: 18
*/

namespace Exercice09
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro número: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Digite o segundo número: ");
            string v2 = Console.ReadLine();

            System.Console.Write("Digite o terceiro número: ");
            string v3 = Console.ReadLine();

            System.Console.Write("Digite o quatro número: ");
            string v4 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2) && int.TryParse(v3, out int n3) && int.TryParse(v4, out int n4))
            {
                System.Console.WriteLine($"A média de {n1}, {n2}, {n3} e {n4} é {(n1 + n2 + n3 + n4) / 4}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}