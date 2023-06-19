using System;

/*
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem 'Sao Multiplos' ou 'Nao sao Multiplos', indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

Exemplos:

Entrada:
6 24

Saída:
Sao Multiplos

Entrada:
6 25

Saída:
Nao sao Multiplos

Entrada:
24 6

Saída:
Sao Multiplos
*/

namespace Exercice09
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.Write("Digite dois valores inteiros: ");
            string[] input = Console.ReadLine().Split();
            A = int.Parse(input[0]);
            B = int.Parse(input[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}