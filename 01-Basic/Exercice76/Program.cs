using System;

/*
Escreva um programa C# para obter o valor ASCII de um determinado caractere.

Exemplo de saída:
O valor Ascii de 1 é: 49
O valor Ascii de A é: 65
O valor Ascii de a é: 97
O valor Ascii de # é: 35

*/

namespace Exercice76
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = '1';
            char character2 = 'A';
            char character3 = 'a';
            char character4 = '#';

            int asciiValue1 = (int)character1;
            int asciiValue2 = (int)character2;
            int asciiValue3 = (int)character3;
            int asciiValue4 = (int)character4;

            Console.WriteLine($"O valor ASCII de {character1} é: {asciiValue1}");
            Console.WriteLine($"O valor ASCII de {character2} é: {asciiValue2}");
            Console.WriteLine($"O valor ASCII de {character3} é: {asciiValue3}");
            Console.WriteLine($"O valor ASCII de {character4} é: {asciiValue4}");
        }
    }
}