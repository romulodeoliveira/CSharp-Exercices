using System;

/*
Escreva um programa C# para calcular a soma dos primeiros 500 números primos.

Exemplo de Saída:
Soma dos 500 primeiros números primos:
824693
*/

namespace Exercice26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[500];
            int cont = 0;
            int number = 2;
            int sum = 0;

            while (cont < 500)
            {
                int dividers = 0;
                int root = (int)Math.Sqrt(number);

                for (int i = 2; i <= root; i++)
                {
                    if (number % i == 0)
                    {
                        dividers++;
                        break;
                    }
                }

                if (dividers == 0)
                {
                    primeNumbers[cont] = number;
                    cont++;
                    sum += number;
                }

                number++;
            }

            System.Console.WriteLine($"Soma dos 500 primeiros números primos: {sum}");

            /*
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                System.Console.Write($"{primeNumbers[i]} || ");
            }

            System.Console.WriteLine();
            */
        }
    }
}
