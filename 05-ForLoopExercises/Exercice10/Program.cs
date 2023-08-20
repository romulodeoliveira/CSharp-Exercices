using System;

/*
Escreva um programa em C# Sharp para exibir um padrão como um triângulo retângulo com um número.
O padrão como:

1
12
123
1234
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of lines: ");
        int lines = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Padrão de triângulo retângulo com números:");
        for (int i = 1; i <= lines; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
