/*
Escreva um programa em C# Sharp para converter um número decimal em binário sem usar um array.
Dados de teste:
Digite um número para converter: 25
Saída esperada :
O binário de 25 é 11001.
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para converter: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        string binaryRepresentation = ConvertDecimalToBinary(decimalNumber);

        Console.WriteLine($"O binário de {decimalNumber} é {binaryRepresentation}");

        Console.ReadLine();
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
