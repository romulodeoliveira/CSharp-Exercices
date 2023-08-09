using System;

/*
Escreva um programa C# Sharp que receba um número decimal como entrada e exiba seu equivalente na forma binária.

Dados de teste:
Número para converter (ou "final")? 25
Saída Esperada:
Binário: 11001
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Número para converter (ou \"final\")? ");
        string input = Console.ReadLine();

        if (input != "final")
        {
            int decimalNumber = int.Parse(input);
            string binary = ConvertDecimalToBinary(decimalNumber);
            Console.WriteLine($"Binário: {binary}");
        }
    }

    static string ConvertDecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binary = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binary = remainder + binary;
            decimalNumber /= 2;
        }

        return binary;
    }
}
