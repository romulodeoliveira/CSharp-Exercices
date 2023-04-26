using System;

/*
Escreva um programa C# para imprimir os números ímpares de 1 a 99. Imprime um número por linha.

Exemplo de Saída:
Números ímpares de 1 a 99. Imprime um número por linha.
1
3
5
7
9
...
95
97
99
*/

namespace Exercice25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}