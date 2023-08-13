using System;

/*
Escreva um programa C# Sharp para exibir o cubo de um número inteiro até determinado número.
Dados de teste:
Insira o número de termos: 5
Saída esperada :
O número é: 1 e o cubo de 1 é: 1 O
número é: 2 e o cubo de 2 é: 8
O número é: 3 e o cubo de 3 é: 27
O número é : 4 e o cubo do 4 é :64
O número é : 5 e o cubo do 5 é :125
*/

namespace Exercice05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o número de termos: ");
        int numTerms = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numTerms; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"O número é: {i} e o cubo de {i} é: {cube}");
        }
    }
}