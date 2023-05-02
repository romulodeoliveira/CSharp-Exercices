using System;

/*
Escreva um programa C# para criar uma nova string onde os 4 primeiros caracteres estarão em letras minúsculas. Se a string tiver menos de 4 caracteres, coloque toda a string em letras maiúsculas.

Dados de teste:
Insira uma string: w3r
Exemplo de saída
W3R
*/

namespace Exercice42
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            if (str.Length < 4)
            {
                System.Console.WriteLine(str.ToUpper());
            }

            else
            {
                string newStr = str.Substring(0, 4).ToLower() + str.Substring(4);
                System.Console.WriteLine(newStr);
            }
        }
    }
}