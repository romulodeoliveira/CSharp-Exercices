/*
Escreva um programa C# Sharp para verificar se a primeira aparição de "a" em uma determinada string é seguida imediatamente por outro "a".

Exemplo de entrada:
"caabb"
"babaaba"
"aaaaa"

Saída esperada:
Verdadeiro
Falso
Verdadeiro
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputs = { "caabb", "babaaba", "aaaaa" };

        Console.WriteLine($"{inputs[0]}: {CheckDoubleA(inputs[0])}");
        Console.WriteLine($"{inputs[1]}: {CheckDoubleA(inputs[1])}");
        Console.WriteLine($"{inputs[2]}: {CheckDoubleA(inputs[2])}");
    }

    static bool CheckDoubleA(string input)
    {
        int firstAIndex = input.IndexOf('a');

        if (firstAIndex != -1 && firstAIndex + 1 < input.Length && input[firstAIndex + 1] == 'a')
        {
            return true;
        }

        return false;
    }
}

