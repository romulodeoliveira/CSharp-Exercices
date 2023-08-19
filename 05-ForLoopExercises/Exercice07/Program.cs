using System;

/*
Escreva um programa em C# Sharp para exibir a tabuada verticalmente de 1 a n.
Dados de teste:
Entrada até o número da tabela começando em 1: 8
Saída esperada :
Tabela de multiplicação de 1 a 8
1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
...
1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número da tabela começando em 1: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabela de multiplicação de 1 a {n}");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                int result = i * j;
                Console.Write($"{j}x{i} = {result}");
                if (j < n)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
