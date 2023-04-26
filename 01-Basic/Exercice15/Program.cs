using System;

/*
Escreva um programa C# para remover um caractere especificado de uma string não vazia usando o índice de um caractere.

Dados de teste:
w3resource
Exemplo de saída:
wresource
w3resource
3resource
*/

namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Olá, Mundo!";

            // Cria uma nova string a partir da posição 5, com 5 caracteres:
            string str1 = str.Substring(5, 5);

            // Cria uma nova string a partir da posição 0, com 3 caracteres:
            string str2 = str.Substring(0, 3);

            // Copia a string str trocando o "á" por "a":
            string str3 = str.Replace("á", "a");

            // Copia a string str3 trocando a "," por "" (nada):
            string str4 = str3.Replace(",", "");

            // Copia a string str4 trocando a "!" por "" (nada):
            string str5 = str4.Replace("!", "");

            // Saída de dados:
            System.Console.WriteLine(str);
            System.Console.WriteLine();
            System.Console.WriteLine(str1);
            System.Console.WriteLine(str1.ToUpper());
            System.Console.WriteLine(str1.ToLower());
            System.Console.WriteLine();
            System.Console.WriteLine(str2);
            System.Console.WriteLine(str2.ToUpper());
            System.Console.WriteLine(str2.ToLower());
            System.Console.WriteLine();
            System.Console.WriteLine(str3);
            System.Console.WriteLine(str4);
            System.Console.WriteLine(str5);
        }
    }
}