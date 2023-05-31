using System;

/*
Escreva um programa C# para verificar se uma determinada palavra está no plural ou não.

Exemplo de saída:
'Exercício' está no plural? Falso
'Exercícios' é plural? Verdadeiro
'Livros' é plural? Verdadeiro
'Livro' é plural? Falso
*/

namespace Exercice77
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Exercício";

            bool isPlural = IsPlural.Word(word);

            Console.WriteLine($"'{word}' está no plural? {isPlural}");
        }
    }
}