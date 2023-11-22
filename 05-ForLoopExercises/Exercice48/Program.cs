/*
Escreva um programa C# Sharp para encontrar números fortes dentro de um intervalo de números.
Dados de teste:
Intervalo de número inicial de entrada: 1
Intervalo de número final de entrada: 200
Saída esperada :
Os números fortes são:
1 2 145
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int start = int.Parse(args[0]);
        int end = int.Parse(args[1]);

        for (int i = start; i <= end; i++)
        {
            int sumOfDivisors = 1;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    sumOfDivisors += j + (i / j);
                }
            }

            if (sumOfDivisors == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
