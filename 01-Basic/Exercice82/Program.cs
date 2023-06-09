﻿using System;

/*
Escreva um programa C# Sharp para remover todos os caracteres que não sejam letras de uma determinada string.

Da Wikipedia,
uma letra é um símbolo segmentar de um sistema de escrita fonêmica. O inventário de todas as letras forma o alfabeto. As letras correspondem amplamente aos fonemas na forma falada do idioma, embora raramente haja uma correspondência consistente e exata entre letras e fonemas
Exemplo de saída:
String original: Py@th12on
Remova todos os caracteres da string mencionada que não são letras: Python
Original string: Python 3.0
Remova todos os caracteres da dita string que não são letras: Python
String original: 2^sdfds*^*^jlljdslfnoswje34u230sdfds984
Remova todos os caracteres da referida string que não são letras: sdfdsjlljdslfnoswjeusdfds
*/

namespace Exercice82;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira uma frase: ");
        string input = Console.ReadLine();

        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLetter(input[i]))
            {
                result += input[i];
            }
        }

        Console.WriteLine($"Str1: {input}");
        Console.WriteLine($"Str2: {result}");
    }
}