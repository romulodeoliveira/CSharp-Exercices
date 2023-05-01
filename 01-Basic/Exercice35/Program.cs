using System;

/*
Escreva um programa C# para verificar dois números em que um é menor que 100 e o outro é maior que 200.

Exemplo de saída:
Insira um primeiro número (<100): 75
Insira um segundo número (>100): 250
True
*/

namespace Exercice35
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
                if (num1 < 100 && num2 > 100)
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