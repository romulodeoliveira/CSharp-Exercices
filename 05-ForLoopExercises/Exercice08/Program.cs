using System;

/*
Escreva um programa C# Sharp para exibir os n termos de números naturais ímpares e suas somas.
Dados de teste
Número de entrada de termos: 10
Saída esperada :
Os números ímpares são: 1 3 5 7 9 11 13 15 17 19
A soma do número natural ímpar até 10 termos: 100
*/


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int count = 0;
        
        Console.Write("Os números ímpares são: ");
        for (int i = 1; count < n; i += 2)
        {
            Console.Write($"{i} ");
            sum += i;
            count++;
        }
        
        Console.WriteLine($"\nA soma dos números ímpares até {n} termos: {sum}");
    }
}
