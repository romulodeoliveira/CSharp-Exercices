/*
Escreva um programa C# Sharp para encontrar o HCF (Maior Fator Comum) de dois números.
Dados de teste:
Insira o 1º número para HCF: 24
Insira o 2º número para HCF: 28
Saída esperada :
HCF de 24 e 28 é: 4
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o 1º número para HCF: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Insira o 2º número para HCF: ");
        int num2 = int.Parse(Console.ReadLine());

        int hcf = FindHCF(num1, num2);

        Console.WriteLine($"HCF de {num1} e {num2} é: {hcf}");

        Console.ReadLine();
    }

    static int FindHCF(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }

        return num1;
    }
}
