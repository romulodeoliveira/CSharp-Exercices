/*
Escreva um programa C# Sharp para calcular o fatorial de um determinado número.
Dados de teste:
Insira o número: 5
Saída esperada :
O fatorial de 5 é: 120
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número: ");
        int numero = int.Parse(Console.ReadLine());

        long fatorial = CalcularFatorial(numero);

        Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
    }

    static long CalcularFatorial(int numero)
    {
        if (numero == 0)
        {
            return 1;
        }
        long fatorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}
