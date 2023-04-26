using System;

/*
Escreva um programa C# para encontrar a palavra mais longa em uma string.

Dados de teste: 
Write a C# Sharp Program to display the following pattern using the alphabet.
Escreva um programa C# Sharp para exibir o seguinte padrão usando o alfabeto.

Saída de amostra:
following
seguinte
*/

namespace Exercice24
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Fortaleza é uma das maiores metrópoles brasileiras";
            string[] words = str.Split(new char[] { ' ', ',', '.', ';', ':', '-', '_', '/' });

            string longestWord = "";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            System.Console.WriteLine(longestWord);
        }
    }
}