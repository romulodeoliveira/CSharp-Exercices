using System;

/*
Escreva um programa C# para verificar se um determinado número positivo é um múltiplo de 3 ou um múltiplo de 7.
Exemplo de saída:
Insira o primeiro inteiro:
15
Verdadeiro
*/

namespace Exercice33
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número inteiro positivo: ");
            string v1 = Console.ReadLine();

            if (int.TryParse(v1, out int num))
            {
                if (num > 0 && num % 3 == 0 || num % 7 == 0)
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
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}