using System;

/*
Escreva um programa C# Sharp para fazer um padrão como um triângulo de ângulo reto com o número aumentado em 1.
O padrão como:

1
2 3
4 5 6
7 8 9 10
*/

class Program
{
    static void Main()
    {
        int lines;
        int number = 1;

        Console.Write("Digite o número de linhas para o padrão: ");
        if (int.TryParse(Console.ReadLine(), out lines))
        {
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro válido.");
        }
    }
}
