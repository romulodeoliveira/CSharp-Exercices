using System;

/*
Escreva um programa C# Sharp para classificar caracteres em uma determinada string (letras maiúsculas/minúsculas e números). Retorne a nova string classificada.

Dados de amostra:
("AAAbfed231") -> "AAAbdef123"
(" ") -> "String em branco!"
("Python") -> "hnoPty"
("W3resource") -> "ceeorrsuW3"
*/

namespace Exercice103;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = { "AAAbfed231", " ", "Python", "W3resource" };

        foreach (string input in inputs)
        {
            string lowercaseLetters = "";
            string uppercaseLetters = "";
            string numbers = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (char.IsLower(c))
                {
                    lowercaseLetters += c;
                }
                else if (char.IsUpper(c))
                {
                    uppercaseLetters += c;
                }
                else if (char.IsDigit(c))
                {
                    numbers += c;
                }
            }

            if (string.IsNullOrEmpty(lowercaseLetters) && string.IsNullOrEmpty(uppercaseLetters) && string.IsNullOrEmpty(numbers))
            {
                Console.WriteLine("Empty string!");
            }
            else
            {
                string result = uppercaseLetters + lowercaseLetters + numbers;
                Console.WriteLine($"Input: {input} -> Output: {result}");
            }
        }
    }
}
