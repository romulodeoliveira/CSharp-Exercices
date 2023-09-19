using System;

/*
Escreva um programa em C# Sharp para fazer um padrão como um triângulo retângulo com um número que repete um número em uma linha.
O padrão como:

1
22
333
4444
*/

class Program
{
    static void Main()
    {
        int lines;

        Console.Write("Digite o número de linhas para o padrão: ");
        if (int.TryParse(Console.ReadLine(), out lines))
        {
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
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
