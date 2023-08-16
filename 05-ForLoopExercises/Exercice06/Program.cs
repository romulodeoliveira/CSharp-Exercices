using System;

/*
Escreva um programa em C# Sharp para exibir a tabela de multiplicação de um determinado número inteiro.
Dados de teste:
Insira o número (tabela a ser calculada): 15
Saída esperada :
15 X 1 = 15
...
...
15 X 10 = 150
*/

namespace Exercice06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o número (tabela a ser calculada): ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabela de multiplicação do número {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} X {i} = {result}");
        }
    }
}