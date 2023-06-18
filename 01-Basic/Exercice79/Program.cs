using System;

/*
Escreva um programa C# para converter um inteiro em string e uma string em um inteiro.

Exemplo de saída:
Valor original e tipo: 50, System.String
Converter string para inteiro:
Valor de retorno e tipo: 50, System.Int32
Valor original e tipo: 122, System.Int32
Converter inteiro para string:
Valor de retorno e type: 122, System.String
*/

namespace Exercice79;

class Program
{
    static void Main()
    {
        int intValue = 50;
        string stringValue = "122";

        Console.WriteLine($"Valor original e tipo: {intValue}, {intValue.GetType()}");
        
        // Converter inteiro em string
        string convertedString = intValue.ToString();
        Console.WriteLine("Converter inteiro para string:");
        Console.WriteLine($"Valor de retorno e tipo: {convertedString}, {convertedString.GetType()}");

        Console.WriteLine();

        Console.WriteLine($"Valor original e tipo: {stringValue}, {stringValue.GetType()}");

        // Converter string em inteiro
        int convertedInt;
        bool success = int.TryParse(stringValue, out convertedInt);
        if (success)
        {
            Console.WriteLine("Converter string para inteiro:");
            Console.WriteLine("Valor de retorno e tipo: " + convertedInt + ", " + convertedInt.GetType());
        }
        else
        {
            Console.WriteLine("Não foi possível converter a string em um inteiro.");
        }
    }
}
