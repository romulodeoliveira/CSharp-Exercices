using System;

/*
Escreva um programa C# para criar uma nova string a partir de uma determinada string em que o primeiro e o último caracteres mudarão de posição.

Dados de teste:
w3resource
Python
Exemplo de saída:
e3resourcew
nythoP
x
*/

namespace Exercice16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "CSHARP";
            string str2 = str1.Substring(5, 1) + str1.Substring(1, 4) + str1.Substring(0, 1);

            System.Console.WriteLine(str2);
        }
    }
}