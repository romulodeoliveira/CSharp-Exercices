using System;

/*
Escreva um programa C# Sharp para criar uma nova string que é n (número inteiro não negativo) cópias de uma determinada string.

Entrada de amostra :
"JS", 2
"JS", 3
"JS", 1

Saída esperada :
JSJS
JSJSJS
js
*/

namespace Exercice25;
    
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CopyString("JS", 2));
        Console.WriteLine(CopyString("JS", 3));
        Console.WriteLine(CopyString("JS", 1));
    }

    static string CopyString(string str, int n)
    {
        return String.Concat(Enumerable.Repeat(str, n));
    }
}
