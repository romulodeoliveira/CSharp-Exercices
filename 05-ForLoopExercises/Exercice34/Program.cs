/*
Escreva um programa em C# Sharp para encontrar números primos dentro de um intervalo de números.
Dados de teste:
Número inicial de entrada do intervalo: 1
Número final de entrada do intervalo: 50
Saída esperada :
Os números primos entre 1 e 50 são:
2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Número de linhas de entrada: ");
        int numRows = int.Parse(Console.ReadLine());

        PrintPascalTriangle(numRows);

        Console.ReadLine();
    }

    static void PrintPascalTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            int num = 1;

            for (int j = 0; j < numRows - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write(num + " ");
                num = num * (i - j) / (j + 1);
            }

            Console.WriteLine();
        }
    }
}
