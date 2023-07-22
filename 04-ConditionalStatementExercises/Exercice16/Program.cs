using System;

/*
Escreva um programa C# Sharp para verificar se um alfabeto é uma vogal ou consoante.

Dados de teste:
k

Saída esperada :
O alfabeto é uma consoante.
*/

namespace Exercice16;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma letra do alfabeto: ");
        char letter = Char.ToLower(Console.ReadKey().KeyChar);

        if (Char.IsLetter(letter))
        {
            if (IsVowel(letter))
            {
                Console.WriteLine("\nA letra é uma vogal.");
            }
            else
            {
                Console.WriteLine("\nA letra é uma consoante.");
            }
        }
        else
        {
            Console.WriteLine("\nEntrada inválida. Por favor, insira apenas uma letra do alfabeto.");
        }
    }

    static bool IsVowel(char letter)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        return Array.Exists(vowels, vowel => vowel == letter);
    }
}

