using System;

/*
Escreva um programa C# Sharp para trocar um determinado número de dois dígitos e verifique se o número fornecido é maior que seu valor de troca.

Exemplo de Saída:
Insira um valor inteiro:
Verifique se o referido valor é maior que seu valor de troca: Verdadeiro
*/

namespace Exercice81;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um valor inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero >= 10 && numero <= 99)
        {
            int dezena = numero / 10;
            int unidade = numero % 10;

            int numeroTroca = (unidade * 10) + dezena;

            Console.WriteLine($"Verifique se o referido valor é maior que seu valor de troca: {numero > numeroTroca}");
        }
        else
        {
            Console.WriteLine("O número fornecido não possui dois dígitos.");
        }
    }
}