using System;

/*
Escreva um programa C# Sharp para ler o valor de um inteiro m e exibir o valor de n é 1 quando m é maior que 0, 0 quando m é 0 e -1 quando m é menor que 0.

Teste Dados: -5

Saída Esperada :
O valor de n = -1
*/

namespace Exercice06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um valor inteiro: ");
        int m = int.Parse(Console.ReadLine());

        int n;

        if (m > 0)
        {
            n = 1;
        }
        else if (m == 0)
        {
            n = 0;
        }
        else
        {
            n = -1;
        }

        Console.WriteLine($"O valor de n = {n}");
    }
}
