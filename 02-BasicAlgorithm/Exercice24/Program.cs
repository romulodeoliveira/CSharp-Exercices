/*
Escreva um programa C# Sharp para converter os últimos 3 caracteres de uma determinada string em letras maiúsculas. Se o comprimento da string for menor que 3, todos os caracteres serão maiúsculos.

Exemplo de entrada :
"Python"
"Javascript"
"js"
"PHP"

Saída esperada :
PytHON
JavascrIPT
JS
PHP
*/

using System;

class Program
{
    static void Main()
    {
        string[] inputs = { "Python", "Javascript", "js", "PHP" };

        foreach (string input in inputs)
        {
            string result = ConvertLastThreeToUpper(input);
            Console.WriteLine(result);
        }
    }

    static string ConvertLastThreeToUpper(string input)
    {
        if (input.Length < 3)
        {
            return input.ToUpper();
        }
        else
        {
            string substring = input.Substring(input.Length - 3);
            string convertedSubstring = substring.ToUpper();
            return input.Substring(0, input.Length - 3) + convertedSubstring;
        }
    }
}
