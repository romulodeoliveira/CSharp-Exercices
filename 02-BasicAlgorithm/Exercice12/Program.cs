using System;

/*
Escreva um programa C# Sharp para verificar se uma determinada string começa com 'C#' ou não.

Exemplo de entrada :
"C# Sharp"
"C#"
"C++"

Saída esperada :
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice12;

class Program
{
    static void Main(string[] args)
    {
        string[] str = new string[] { "Python", "JS", "CSharp", "C#"};

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i][0] == 'C' && str[i][1] == '#')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}