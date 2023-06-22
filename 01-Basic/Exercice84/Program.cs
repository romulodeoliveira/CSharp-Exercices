using System;

/*
Escreva um programa C# Sharp para obter o número de índice de todas as letras minúsculas em uma determinada string.

Exemplo de saída:
String original: Python
Índices de todas as letras minúsculas da referida string:
1 2 3 4 5
String original: JavaScript
Índices de todas as letras minúsculas da referida string:
1 2 3 5 6 7 8 9
*/

namespace Exercice84;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira uma frase: ");
        string input = Console.ReadLine();

        int h = 0;
        List<int> index = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLower(input[i]))
            {
                index.Add(i);
                h++;
            }
        }

        for (int j = 0; j < index.Count; j++)
        {
            Console.Write($"{index[j]} ");
        }
    }
}