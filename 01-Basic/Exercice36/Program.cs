using System;

/*
Escreva um programa C# para verificar se um número inteiro (dos dois números inteiros fornecidos) está no intervalo -10 a 10.

Exemplo de saída:
Insira um primeiro número: -5
Insira um segundo número: 8
Verdadeiro
*/

namespace Exercice36
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um primeiro número: ");
            string str1 = Console.ReadLine();

            System.Console.Write("Insira um segundo número: ");
            string str2 = Console.ReadLine();

            if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2))
            {
                if (num1 < 10 && num1 > -10 && num2 < 10 && num2 > -10)
                {
                    System.Console.WriteLine("Verdadeiro");
                }

                else
                {
                    System.Console.WriteLine("Falso");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados inválida. Insira apenas números inteiros.");
            }
        }
    }
}