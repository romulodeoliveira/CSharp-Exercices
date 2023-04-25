using System;

/*
Escreva um programa C# Sharp para imprimir a saída da multiplicação de três números que serão inseridos pelo usuário.

Dados de teste:
Insira o primeiro número para multiplicar: 2
Insira o segundo número para multiplicar: 3
Insira o terceiro número para multiplicar: 6

Saída esperada:
2 x 3 x 6 = 36
*/

namespace Exercice06
{
    class Program
    {
        public static void Main(string[] args)
        {

            System.Console.Write("Insira o primeiro número para multiplicar: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Insira o segundo número para multiplicar: ");
            string v2 = Console.ReadLine();

            System.Console.Write("Insira o terceiro número para multiplicar: ");
            string v3 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2) && int.TryParse(v3, out int n3))
            {
                System.Console.WriteLine($"{n1} x {n2} x {n3} = {n1 * n2 * n3}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Digite números inteiros.");
            }

        }
    }
}