using System;

/*
Escreva um programa C# para criar uma nova string de todos os outros caracteres (posição ímpar) a partir da primeira posição de uma determinada string.

Dados de teste:
Insira uma string: w3resource
Exemplo de saída
wrsuc
*/

namespace Exercice44
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newStr += str[i];
                }
            }

            System.Console.WriteLine(newStr);
        }
    }
}