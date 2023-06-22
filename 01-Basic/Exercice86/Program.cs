using System;

/*
Escreva um programa C# Sharp para obter o número de letras e dígitos em uma determinada string.

Exemplo de saída:
String original:: Python 3.0
Número de letras: 6 Número de dígitos: 2
String original:: dsfkaso230samdm2423sa
Número de letras: 14 Número de dígitos: 7
*/

namespace Exercice86;

class Program
{
    static void Main(string[] args)
    {
        string str = "dsfkaso230samdm2423sa";

        int letter = 0;
        int number = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsLetter(str[i]))
            {
                letter += 1;
            }
            else if (Char.IsNumber(str[i]))
            {
                number += 1;
            }
        }

        Console.WriteLine($"Letras: {letter}\nNumeros: {number}");
    }
}