using System;

/*
Escreva um programa C# Sharp para criar uma nova string com o último caractere adicionado na frente e atrás de uma determinada string de comprimento 1 ou mais.

Entrada de amostra :
"Red"
"Green"
"1"

Saída esperada :
dRedd
nGreenn
111
*/

namespace Exercice09;

class Pogram
{
    static void Main(string[] args)
    {
        string str = "Red";

        Console.WriteLine($"{str[str.Length - 1]}{str}{str[str.Length - 1]}");
    }
}