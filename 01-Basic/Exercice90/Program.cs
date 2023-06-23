using System;

/*
Escreva um programa C# Sharp para contar o número de uns e zeros na representação binária de um determinado número inteiro.

Exemplo de saída:
Número original: 12
Número de uns e zeros na representação binária do referido número:
Número de uns: 2
Número de zeros: 2
Número original: 1234
Número de uns e zeros na representação binária do dito número:
Número de uns: 5
Número de zeros: 6
*/

namespace Exercice90;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string representacaoBinaria = Convert.ToString(numero, 2);
        int numeroDeUns = 0;
        int numeroDeZeros = 0;

        foreach (char digito in representacaoBinaria)
        {
            if (digito == '1')
            {
                numeroDeUns++;
            }
            else if (digito == '0')
            {
                numeroDeZeros++;
            }
        }

        Console.WriteLine("Número original: " + numero);
        Console.WriteLine("Número de uns e zeros na representação binária do referido número:");
        Console.WriteLine("Número de uns: " + numeroDeUns);
        Console.WriteLine("Número de zeros: " + numeroDeZeros);
    }
}
