using System;

/*
Escreva um programa C# Sharp para ler 10 números e encontrar sua média e soma.
Dados de teste:
Insira os 10 números:
Número-1:2
...
Número-10:2
Saída esperada :
A soma de 10 não é: 51
A média é: 5,100000
*/

namespace Exercice04;

class Program
{
    static void Main(string[] args)
    {
        int quantityNumbers = 10;
        int sum = 0;

        Console.WriteLine($"Insira os {quantityNumbers} números:");

        for (int i = 1; i <= quantityNumbers; i++)
        {
            Console.Write($"Número-{i}: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        double average = (double)sum / quantityNumbers;

        Console.WriteLine($"A soma dos {quantityNumbers} números é: {sum}");
        Console.WriteLine($"A média é: {average.ToString("F6")}");
}
}