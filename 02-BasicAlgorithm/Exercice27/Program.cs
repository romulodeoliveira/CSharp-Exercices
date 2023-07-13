using System;

/*
Escreva um programa C# Sharp para contar a string "aa" em uma determinada string e assumir que "aaa" contém dois "aa".

Exemplo de entrada:
"bbaaccaag"
"jjkiaaasew"
"JSaaakoiaa"

Saída esperada:
2
2
3
*/

namespace Exercice27;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountSubstringOccurrences("bbaaccaag", "aa"));
        Console.WriteLine(CountSubstringOccurrences("jjkiaaasew", "aa"));
        Console.WriteLine(CountSubstringOccurrences("JSaaakoiaa", "aa"));
    }

    static int CountSubstringOccurrences(string input, string substring)
    {
        int count = 0;
        int index = 0;
        while ((index = input.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length - 1;
        }

        return count;
    }
}
