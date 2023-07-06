using System;

/*
Escreva um programa C# Sharp para criar uma nova string usando os 3 primeiros caracteres de uma determinada string e retorne a string com os 3 caracteres adicionados na frente e atrás. Se o comprimento da string for menor que 3, use os caracteres que estiverem lá.

Exemplo de entrada :
"Python"
"JS"
"Código"

Saída esperada :
PytPythonPytGenericName
JSJSJS
CodCodeCod
*/

namespace Exercice11;

class Program
{
    static void Main(string[] args)
    {
        string[] str = new string[] { "Python", "JS", "Código"};

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length < 3)
            {
                Console.WriteLine($"{str[i]}{str[i]}{str[i]}");
            }
            else
            {
                Console.WriteLine($"{str[i][0]}{str[i][1]}{str[i][2]}{str[i]}{str[i][0]}{str[i][1]}{str[i][2]}");
            }
        }
    }
}