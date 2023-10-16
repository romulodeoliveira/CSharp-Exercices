/*
Escreva um programa em C# Sharp para exibir os n termos de um número natural par e sua soma.
Dados de teste:
Número de termos de entrada: 5
Saída esperada :
Os números pares são: 2 4 6 8 10
A soma do número natural par até 5 termos: 30
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Número de termos de entrada: ");
        int n = int.Parse(Console.ReadLine());

        int soma = 0;
        Console.Write("Os números pares são: ");
        for (int i = 1; i <= n; i++)
        {
            int numeroPar = 2 * i;
            soma += numeroPar;

            Console.Write(numeroPar);
            if (i < n)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
        Console.WriteLine("A soma do número natural par até " + n + " termos: " + soma);
    }
}
