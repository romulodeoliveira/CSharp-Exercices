using System;

/*
Escreva um programa C# para converter um número hexadecimal em decimal.

Exemplo de saída:
Número hexadecimal: 4B0
Converter para
número decimal: 1200
*/

namespace Exercice30
{
    class Program
    {
        static void Main(string[] args)
        {

            string hexNumber = "1A82";
            int decimalNumber = Convert.ToInt32(hexNumber, 16);
            System.Console.WriteLine(decimalNumber);
        }
    }
}