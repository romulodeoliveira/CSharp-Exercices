using System;

/*
Escreva um programa C# Sharp para criar uma nova string que é n (número inteiro não negativo) cópias dos primeiros 3 caracteres de uma determinada string. Se o comprimento da string fornecida for menor que 3, retorne n cópias da string.

Exemplo de entrada :
"Python", 2
"Python", 3
"JS", 3

Saída esperada :
PytPyt
PytPytPyt
JSJSJS

*/

namespace Exercice26;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CopyFirstThreeChars("Python", 2));
        Console.WriteLine(CopyFirstThreeChars("Python", 3));
        Console.WriteLine(CopyFirstThreeChars("JS", 3));
    }

    static string CopyFirstThreeChars(string str, int n)
    {
        string firstThreeChars = str.Length >= 3 ? str.Substring(0, 3) : str;
        return String.Concat(Enumerable.Repeat(firstThreeChars, n));
    }
}
