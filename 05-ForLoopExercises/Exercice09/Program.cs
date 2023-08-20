using System;

/*
Escreva um programa em C# Sharp para exibir um triângulo retângulo com um asterisco.
O padrão como:

*
**
***
****
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de linhas: ");
        int linhas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Padrão de triângulo retângulo:");
        for (int i = 1; i <= linhas; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
