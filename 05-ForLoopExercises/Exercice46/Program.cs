/*
Escreva um programa C# Sharp para converter um número binário em um número decimal usando a função matemática.
Dados de teste:
Insira o número binário: 1010100
Saída esperada :
O número binário: 1010100
O número decimal equivalente é: 84
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número binário: ");
        string binaryNumber = Console.ReadLine();

        int decimalNumber = BinaryToDecimal(binaryNumber);

        Console.WriteLine($"O número binário: {binaryNumber}");
        Console.WriteLine($"O número decimal equivalente é: {decimalNumber}");

        Console.ReadLine();
    }

    static int BinaryToDecimal(string binary)
    {
        int decimalNumber = 0;

        for (int i = binary.Length - 1, j = 0; i >= 0; i--, j++)
        {
            int bit = int.Parse(binary[i].ToString());
            decimalNumber += bit * (int)Math.Pow(2, j);
        }

        return decimalNumber;
    }
}
