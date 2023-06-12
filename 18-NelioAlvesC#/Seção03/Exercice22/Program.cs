using System;

/*
Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.

------------

Exemplos:

------------

Entrada:
4

Saída:
24

------------

Entrada:
1

Saída:
1

------------

Entrada:
5

Saída:
120

------------

Entrada:
0

Saída:
1
*/

namespace Exercice22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;

            if (n >= 0)
            {
                for (int i = n; i > 1; i--)
                {
                    fatorial *= i;
                }
            }
            else
            {
                Console.WriteLine("O fatorial não está definido para números negativos.");
                return;
            }

            Console.WriteLine($"O fatorial de {n} é: {fatorial}");
        }
    }
}