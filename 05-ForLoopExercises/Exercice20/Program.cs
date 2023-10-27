/*
Escreva um programa em C# Sharp para exibir o padrão como pirâmide usando um asterisco e cada linha contém um número ímpar de asteriscos.

  *
 ***
*****
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de linhas para a pirâmide: ");
        int numberOfLines = Convert.ToInt32(Console.ReadLine());

        DisplayPyramidPattern(numberOfLines);

        Console.ReadLine();
    }

    static void DisplayPyramidPattern(int n)
    {
        Console.WriteLine("Padrão de Pirâmide:");

        for (int i = 1; i <= n; i += 2)
        {
            for (int j = 0; j < (n - i) / 2; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
