using System;

/*
Escreva um programa C# Sharp para verificar dois números inteiros fornecidos e retorne true se um deles for 30 ou se a soma for 30.

Entrada de amostra :
30, 0
25, 5
20, 30
20, 25

Saída esperada :
Verdadeiro
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            System.Console.Write("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 + num2 == 30 || num1 == 30 || num2 == 30)
            {
                System.Console.WriteLine("Verdadeiro");
            }

            else
            {
                System.Console.WriteLine("False");
            }
        }
    }
}