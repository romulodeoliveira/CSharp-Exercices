/*
Escreva um programa em C# Sharp para encontrar o LCM de quaisquer dois números.
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
        Console.Write("Insira o 1º número para o LCM: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o 2º número para o LCM: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"O LCM de {num1} e {num2} é: {lcm}");

        Console.ReadLine();
    }

    static int FindLCM(int a, int b)
    {
        int gcd = FindGCD(a, b);
        int lcm = (a * b) / gcd;
        return lcm;
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
