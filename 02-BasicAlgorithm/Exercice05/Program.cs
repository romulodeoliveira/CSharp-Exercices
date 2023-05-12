using System;

/*
Escreva um programa C# Sharp para criar uma nova string onde 'if' é adicionado à frente de uma determinada string. Se a string já começar com 'if', retorne a string inalterada.

Exemplo de entrada :
"if else"
"else"

Saída esperada :
se mais
se mais
*/

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a vida é uma droga";
            string[] strArray = str.Split(" ");

            if (strArray[0] != "se")
            {
                System.Console.WriteLine($"se {str}");
            }
        }
    }
}