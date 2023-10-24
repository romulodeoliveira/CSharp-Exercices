/*
Escreva um programa em C# Sharp para fazer um padrão como uma pirâmide com um número que repetirá o número na mesma linha.

   1
  2 2
 3 3 3
4 4 4 4
*/

using System;

class Program
{
    static void Main()
    {
        int linhas;

        Console.Write("Digite o número de linhas para a pirâmide: ");
        linhas = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= linhas; i++)
        {
            for (int j = 1; j <= linhas - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        Console.ReadLine(); 
    }
}
