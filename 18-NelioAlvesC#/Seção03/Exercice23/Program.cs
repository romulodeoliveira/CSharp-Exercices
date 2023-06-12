using System;

/*
Ler um número inteiro N e calcular todos os seus divisores.

Exemplo:

Entrada:
6

Saída:
1
2
3
6
*/

namespace Exercice23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Os divisores de {n} são:");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}