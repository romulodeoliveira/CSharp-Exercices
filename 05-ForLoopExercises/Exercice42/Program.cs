/*
Escreva um programa em C# Sharp para converter um número binário em um número decimal sem usar array, função e loop while.
Dados de teste:
Insira um número binário: 1010101
Saída esperada :
O número binário: 1010101
O número decimal equivalente: 85
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número binário: ");
        string binaryNumber = Console.ReadLine();

        int decimalEquivalent = ConvertBinaryToDecimal(binaryNumber);

        Console.WriteLine($"O número binário: {binaryNumber}");
        Console.WriteLine($"O número decimal equivalente: {decimalEquivalent}");

        Console.ReadLine();
    }

    static int ConvertBinaryToDecimal(string binaryNumber)
    {
        int decimalEquivalent = 0;
        int binaryLength = binaryNumber.Length;

        for (int i = 0; i < binaryLength; i++)
        {
            char binaryDigit = binaryNumber[binaryLength - 1 - i];
            int digitValue = (binaryDigit == '1') ? 1 : 0;
            decimalEquivalent += digitValue * (int)Math.Pow(2, i);
        }

        return decimalEquivalent;
    }
}
