using System;

/*
Escreva um programa C# Sharp para remover todas as vogais de uma determinada string.

Exemplo de saída:
String original: Python
Depois de remover todas as vogais da string: Pythn
String original: C Sharp
Depois de remover todas as vogais da string: C Shrp
String original: JavaScript
Depois de remover todas as vogais da string dita string: JvScrpt
*/

namespace Exercice83;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma frase: ");
        string input = Console.ReadLine();
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != 'a' && input[i] != 'e' && input[i] != 'i' && input[i] != 'o' && input[i] != 'u')
            {
                result += input[i];
            }
        }

        Console.WriteLine($"Str1 = {input}");
        Console.WriteLine($"Str2 = {result}");
    }
}