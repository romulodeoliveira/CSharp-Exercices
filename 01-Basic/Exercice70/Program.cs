using System;

/*
Escreva um programa C# Sharp para remover o primeiro e o último elemento de uma determinada string. 

Exemplo de saída:
String original: PHP
Depois de remover o primeiro e o último elemento: H
String original: Python
Depois de remover o primeiro e o último elemento: ytho
String original: JavaScript
Depois de remover o primeiro e o último elemento: avaScrip
*/

namespace Exercice70
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ola Mundo";

            string str1 = str.Substring(1, str.Length - 2);

            Console.WriteLine("String original: " + str);
            Console.WriteLine("Depois de remover o primeiro e o último elemento: " + str1);
        }
    }
}