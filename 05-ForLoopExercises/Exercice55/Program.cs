/*
Escreva um programa em C# Sharp para converter um número decimal em hexadecimal. .
Dados de teste:
Insira qualquer número decimal: 79
Saída esperada :
O número hexadecimal equivalente: 4F
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira qualquer número decimal: ");
        int decimalInput = int.Parse(Console.ReadLine());

        string hexadecimalOutput = DecimalToHexadecimal(decimalInput);

        Console.WriteLine($"O número hexadecimal equivalente: {hexadecimalOutput}");
    }

    static string DecimalToHexadecimal(int decimalNumber)
    {
        string hexadecimalResult = Convert.ToString(decimalNumber, 16).ToUpper();

        return hexadecimalResult;
    }
}
