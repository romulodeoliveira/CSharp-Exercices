/*
Escreva um programa em C# Sharp para exibir os primeiros n termos da série de Fibonacci.
Série Fibonacci 0 1 2 3 5 8 13 .....
Dados de teste:
Insira o número de termos a serem exibidos: 10
Saída esperada :
Aqui está a série Fibonacci até 10 termos:
0 1 1 2 3 5 8 13 21 34
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de termos a serem exibidos: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Aqui está a série Fibonacci até {n} termos:");
        PrintFibonacciSeries(n);

        Console.ReadLine();
    }

    static void PrintFibonacciSeries(int n)
    {
        int firstTerm = 0, secondTerm = 1, nextTerm;

        for (int i = 0; i < n; i++)
        {
            Console.Write(firstTerm + " ");

            nextTerm = firstTerm + secondTerm;
            firstTerm = secondTerm;
            secondTerm = nextTerm;
        }
    }
}
