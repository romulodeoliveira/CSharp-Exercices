using System;

/*
Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

EXEMPLO:

Entrada:
-10

Saída:
NEGATIVO

Entrada:
8

Saída:
NAO NEGATIVO

Entrada:
0

Saída:
NAO NEGATIVO
*/

namespace Exercice07
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int num))
            {
                if (IsPositive.Number(num))
                {
                    System.Console.WriteLine("Número positivo.");
                }
                else
                {
                    System.Console.WriteLine("Número negativo.");
                }
            }
            else
            {
                System.Console.WriteLine("Insira um número inteiro válido.");
            }
        }
    }
}