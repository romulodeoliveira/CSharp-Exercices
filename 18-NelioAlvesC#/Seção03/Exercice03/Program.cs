using System;

/*
Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
*/

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro valor: ");
            string str1 = Console.ReadLine();

            System.Console.Write("Insira o segundo valor: ");
            string str2 = Console.ReadLine();

            System.Console.Write("Insira o terceiro valor: ");
            string str3 = Console.ReadLine();

            System.Console.Write("Insira o quarto valor: ");
            string str4 = Console.ReadLine();

            if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2) && int.TryParse(str3, out int num3) && int.TryParse(str4, out int num4))
            {
                System.Console.WriteLine((num1 * num2) - (num3 * num4));
            }

            else
            {
                System.Console.WriteLine();
            }
        }
    }
}