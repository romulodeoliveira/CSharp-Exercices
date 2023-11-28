/*
Escreva um programa em C# Sharp para converter um número octal em binário.
Dados de teste:
Insira um número octal: 11
Saída esperada :
O número octal: 11
O número binário equivalente: 1001
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira um número octal: ");
        string octalInput = Console.ReadLine();

        string binaryOutput = OctalToBinary(octalInput);

        Console.WriteLine($"O número octal: {octalInput}");
        Console.WriteLine($"O número binário equivalente: {binaryOutput}");
    }

    static string OctalToBinary(string octalNumber)
    {
        string binaryResult = "";
        foreach (char octalDigit in octalNumber)
        {
            int decimalValue = Convert.ToInt32(octalDigit.ToString(), 8);
            string binaryDigit = Convert.ToString(decimalValue, 2).PadLeft(3, '0');
            binaryResult += binaryDigit;
        }

        return binaryResult;
    }
}
