using System;

/*
Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

Exemplos:

Entrada:
12

Saída:
PAR

Entrada:
-27

Saída:
IMPAR

Entrada:
0

Saída:
PAR
*/

namespace Exercice08
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um número: ");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int num))
            {
                if (IsEven.Number(num))
                {
                    System.Console.WriteLine("Par");
                }
                else
                {
                    System.Console.WriteLine("Impar");
                }
            }
            else
            {
                System.Console.WriteLine("Insira um número inteiro.");
            }
        }
    }
}