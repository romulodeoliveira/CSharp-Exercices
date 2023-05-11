using System;

/*
Escreva um programa C# Sharp para obter a diferença absoluta entre n e 51. Se n for maior que 51, retorne o triplo da diferença absoluta.

Entrada de amostra :
53
30
51

Saída esperada :
6
21
0
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());

            System.Console.WriteLine(Math.Abs(num - 51));
        }
    }
}