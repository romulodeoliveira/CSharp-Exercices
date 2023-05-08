using System;

// Escreva um programa C# para inverter as strings contidas em cada par de parênteses correspondentes em uma determinada string e também remover os parênteses dentro da string fornecida.

namespace Exercice62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira uma frase: ");
            string input = Console.ReadLine();

            string result = ReverseStringsInParentheses(input);

            Console.WriteLine("Resultado: " + result);
        }

        static string ReverseStringsInParentheses(string input)
        {
            int start = input.LastIndexOf('(');

            while (start != -1)
            {
                int end = input.IndexOf(')', start);
                if (end == -1)
                    break;

                string substring = input.Substring(start + 1, end - start - 1);
                char[] charArray = substring.ToCharArray();
                Array.Reverse(charArray);
                string reversedSubstring = new string(charArray);

                input = input.Remove(start, end - start + 1);
                input = input.Insert(start, reversedSubstring);

                start = input.LastIndexOf('(');
            }

            input = input.Replace("(", "").Replace(")", "");

            return input;
        }
    }
}