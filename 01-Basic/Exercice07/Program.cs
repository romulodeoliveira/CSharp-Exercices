using System;

/*
7. Escreva um programa C# Sharp para imprimir na tela a saída da adição, subtração, multiplicação e divisão de dois números que serão inseridos pelo usuário.

Dados de teste:
Insira o primeiro número: 25
Insira o segundo número: 4
Saída esperada:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1
*/

namespace Exercice07
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro número: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Insira o segundo número: ");
            string v2 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2))
            {
                System.Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                System.Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                System.Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
                System.Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                System.Console.WriteLine($"{n1} mod {n2} = {n1 % n2}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}