/*
Escreva um programa C# Sharp para criar uma nova string composta de todos os outros caracteres começando com o primeiro de uma determinada string.

Exemplo de entrada:
"Python"
"PHP"
"JS"

Saída esperada:
tomada de força
PP
J
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = { "Python", "PHP", "JS" };

        foreach (string input in inputs)
        {
            string result = CreateNewString(input);
            Console.WriteLine(result);
        }
    }

    static string CreateNewString(string input)
    {
        string newString = "";
        for (int i = 0; i < input.Length; i += 2)
        {
            newString += input[i];
        }
        return newString;
    }
}
