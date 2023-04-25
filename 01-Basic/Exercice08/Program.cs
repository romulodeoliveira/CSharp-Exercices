using System;

/*
Escreva um programa C# Sharp que receba um número como entrada e imprima sua tabela de multiplicação.

Dados de teste:
Digite o número: 5
Saída esperada:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50
*/

namespace Exercice08
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Digite o número: ");
            string v1 = Console.ReadLine();

            if (int.TryParse(v1, out int n1))
            {
                System.Console.WriteLine($"{n1} x 0 = {n1 * 0}");
                System.Console.WriteLine($"{n1} x 1 = {n1 * 1}");
                System.Console.WriteLine($"{n1} x 2 = {n1 * 2}");
                System.Console.WriteLine($"{n1} x 3 = {n1 * 3}");
                System.Console.WriteLine($"{n1} x 4 = {n1 * 4}");
                System.Console.WriteLine($"{n1} x 5 = {n1 * 5}");
                System.Console.WriteLine($"{n1} x 6 = {n1 * 6}");
                System.Console.WriteLine($"{n1} x 7 = {n1 * 7}");
                System.Console.WriteLine($"{n1} x 8 = {n1 * 8}");
                System.Console.WriteLine($"{n1} x 9 = {n1 * 9}");
                System.Console.WriteLine($"{n1} x 10 = {n1 * 10}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados inválida. Digite apenas números inteiros.");
            }
        }
    }
}