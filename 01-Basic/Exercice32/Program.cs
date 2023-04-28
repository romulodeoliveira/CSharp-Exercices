using System;

/*
Escreva um programa C# para criar uma nova string de quatro cópias, pegando os últimos quatro caracteres de uma determinada string.
Se o comprimento da string fornecida for menor que 4, retorne o original.

Exemplo de saída:

The quick brown fox jumps over the lazy dog.
dog.dog.dog.dog.
*/

namespace Exercice32
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string input = Console.ReadLine();

            string[] words = input.Split(" ");

            if (words.Length < 4)
            {
                System.Console.WriteLine(input);
            }

            else
            {
                for (int i = 0; i < 4; i++)
                {
                    System.Console.Write(words[words.Length - 1]);
                }
                System.Console.WriteLine();
            }
        }
    }
}