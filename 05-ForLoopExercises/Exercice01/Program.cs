using System;

/*
Escreva um programa em C# Sharp para exibir os 10 primeiros números naturais.
Resultado Esperado :
1 2 3 4 5 6 7 8 9 10
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                System.Console.Write($"{i} ");
            }
            System.Console.WriteLine();
        }
    }
}

