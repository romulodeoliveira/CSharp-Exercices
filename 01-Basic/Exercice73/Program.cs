using System;

/*
Escreva um programa C# para converter as letras de uma determinada string (mesma maiúscula/minúscula) em ordem alfabética.

Exemplo de saída:

String original: PHP
Converter as letras da string em ordem alfabética: HPP

String original: javascript
Converter as letras da string em ordem alfabética: aacijprstv

String original: python
Converter as letras da string em questão em ordem alfabética: hnopty
*/

namespace Exercice73
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "python";
            string str2 = "csharp";
            string str3 = "javascript";

            string sortedString1 = SortStringAlphabetically.Alpha(str1);
            string sortedString2 = SortStringAlphabetically.Alpha(str2);
            string sortedString3 = SortStringAlphabetically.Alpha(str3);

            System.Console.Write("| ");
            System.Console.Write($"{str1} | ");
            System.Console.Write($"{str2} | ");
            System.Console.Write($"{str3} | ");
            System.Console.WriteLine();

            System.Console.Write("| ");
            System.Console.Write($"{sortedString1} | ");
            System.Console.Write($"{sortedString2} | ");
            System.Console.Write($"{sortedString3} | ");
            System.Console.WriteLine();
        }
    }
}