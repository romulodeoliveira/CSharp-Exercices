/*
Escreva um programa em C# Sharp para encontrar o LCM de quaisquer dois números usando HCF.
Dados de teste:
Insira o 1º número para LCM: 15
Insira o 2º número para LCM: 20
Saída esperada :
O LCM de 15 e 20 é: 60
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o 1º número para LCM: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Insira o 2º número para LCM: ");
        int num2 = int.Parse(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"O LCM de {num1} e {num2} é: {lcm}");

        Console.ReadLine();
    }

    static int FindLCM(int num1, int num2)
    {
        int hcf = FindHCF(num1, num2);
        int lcm = (num1 * num2) / hcf;

        return lcm;
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
