using System;

/*
Escreva um programa C# para criar uma nova string a partir de uma determinada string (comprimento 1 ou mais) com o primeiro caractere adicionado na frente e atrás.

Exemplo de saída:
Insira uma string: A rápida raposa marrom pula sobre o cachorro preguiçoso.
AA rápida raposa marrom pula sobre o cachorro preguiçoso.A
*/

namespace Exercice17
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C# é muito legal!";

            string str2 = str1.Substring(0, 1) + str1 + str1.Substring(0, 1);

            System.Console.WriteLine(str2);
        }
    }
}