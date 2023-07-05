using System;

/*
Escreva um programa C# Sharp para criar uma nova string com 4 cópias dos 2 caracteres frontais de uma determinada string. Se o comprimento da string fornecido for menor que 2, retorne a string original.

Exemplo de entrada :
"C Sharp"
"JS"
"a"

Saída esperada :
CCCC
JSJSJSJS
a

*/

namespace Exercice08;

class Program
{
    static void Main(string[] args)
    {
        string[] str = new string[] { "C Sharp", "JS", "a" };

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length < 2)
            {
                Console.WriteLine(str[i]);
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
