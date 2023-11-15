/*
Escreva um programa C# Sharp para encontrar os números 'perfeitos' dentro de um determinado intervalo de números.
Dados de teste:
Insira o intervalo ou número inicial: 1
Insira o intervalo final do número: 50
Saída esperada :
Os números perfeitos dentro do intervalo fornecido: 6 28
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o intervalo inicial: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Insira o intervalo final: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Os números perfeitos dentro do intervalo fornecido:");

        for (int num = start; num <= end; num++)
        {
            if (IsPerfectNumber(num))
            {
                Console.Write(num + " ");
            }
        }

        Console.ReadLine();
    }

    static bool IsPerfectNumber(int num)
    {
        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum == num;
    }
}
