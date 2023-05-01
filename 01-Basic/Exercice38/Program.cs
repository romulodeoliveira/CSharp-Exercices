using System;

/*
Escreva um programa C# para obter uma nova string de dois caracteres de uma determinada string. O primeiro e o segundo caractere da string fornecida devem ser "P" e "H", então o PHP será "PH".

Dados de teste: PHP
Exemplo de saída:
PH
*/

namespace Exercice38
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            string newStr = str.Substring(0, 2);

            System.Console.WriteLine(newStr);
        }
    }
}