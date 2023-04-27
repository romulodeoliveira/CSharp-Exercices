using System;

/*
Escreva um programa C# para inverter as palavras de uma frase.

Exemplo de Saída:

Input: "The quick brown fox jumps over the lazy dog."
Output: "dog. lazy the over jumps fox brown quick The"

Input: "Programming is fun!"
Output: "fun! is Programming"

Input: "Hello, world!"
Output: "world! Hello,"
*/

namespace Exercice28
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(" ");

            int iteration = words.Length;
            iteration = iteration - 1;

            while (iteration != -1)
            {
                System.Console.Write($"{words[iteration]} ");

                iteration--;
            }

            System.Console.WriteLine();
        }
    }
}

// O rato roeu a roupa do rei de roma!