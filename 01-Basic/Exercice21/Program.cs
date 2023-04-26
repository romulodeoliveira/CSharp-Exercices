using System;

/*
Escreva um programa em C# para verificar a soma dos dois inteiros fornecidos e retorne true se um dos inteiros for 20 ou se a soma for 20.
*/

namespace Exercice21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro número: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Insira o segundo número: ");
            string v2 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2))
            {
                if (n1 == 20 || n2 == 20 || n1 + n2 == 20)
                {
                    System.Console.WriteLine("Verdadeiro.");
                }

                else
                {
                    System.Console.WriteLine("Falso");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}