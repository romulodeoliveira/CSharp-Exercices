using System;

/*
Escreva um programa C# Sharp para ler a idade de um candidato e determinar se ele é elegível para votar.

Dados de teste: 21

Saída esperada :
Parabéns! Você é elegível para votar.
*/

namespace Exercice05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a idade do candidato: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Parabéns! Você é elegível para votar.");
        }
        else
        {
            Console.WriteLine("Desculpe, você não é elegível para votar.");
        }
    }
}
