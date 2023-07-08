using System;

/*
Escreva um programa C# Sharp para verificar se uma string 'yt' aparece no índice 1 em uma determinada string. Se aparecer, retorne uma string sem 'yt' caso contrário, retorne a string original.

Sample Input:
"Python"
"ytade"
"jsues"

Expected Output:
Phon
ytade
jsues
*/

namespace Exercice17;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveYT("Python"));
        Console.WriteLine(RemoveYT("ytade"));
        Console.WriteLine(RemoveYT("jsues"));
    }

    static string RemoveYT(string input)
    {
        if (input.Length > 1 && input.Substring(1, 2) == "yt")
        {
            return input.Remove(1, 2);
        }
        else
        {
            return input;
        }
    }
}