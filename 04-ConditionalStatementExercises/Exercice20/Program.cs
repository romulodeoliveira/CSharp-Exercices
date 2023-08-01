using System;

/*
Escreva um programa em C# Sharp para ler qualquer número de dia inteiro e exibir o nome do dia na palavra.

Dados de teste:
4

Saída esperada :
quinta-feira
*/

namespace Exercice20;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número de 1 a 7: ");
        int number = int.Parse(Console.ReadLine());

        string result = "";

        if (number == 1)
        {
            result = "Domingo";
        }
        else if (number == 2)
        {
            result = "Segunda-feira";
        }
        else if (number == 3)
        {
            result = "Terça-feira";
        }
        else if (number == 4)
        {
            result = "Quarta-feira";
        }
        else if (number == 5)
        {
            result = "Quinta-feira";
        }
        else if (number == 6)
        {
            result = "Sexta-feira";
        }
        else if (number == 7)
        {
            result = "Sábado";
        }
        else
        {
            Console.WriteLine("Número inválido");
        }

        Console.WriteLine(result);
    }
}