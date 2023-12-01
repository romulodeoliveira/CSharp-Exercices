/*
Escreva um programa em C# Sharp para imprimir uma string na ordem inversa.
Dados de teste:
Insira uma string para reverter: Bem-vindo
Saída esperada :
A string invertida é: emocleW
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira uma string para reverter: ");
        string inputString = Console.ReadLine();

        string reversedString = ReverseString(inputString);

        Console.WriteLine($"A string invertida é: {reversedString}");
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
