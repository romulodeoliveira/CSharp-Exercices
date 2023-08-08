using System;

/*
Escreva um programa C# Sharp que receba dois números como entrada e retorne verdadeiro ou falso quando ambos os números forem pares ou ímpares.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        bool areEven = (num1 % 2 == 0) && (num2 % 2 == 0);
        bool areOdd = (num1 % 2 != 0) && (num2 % 2 != 0);

        if (areEven || areOdd)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
}
