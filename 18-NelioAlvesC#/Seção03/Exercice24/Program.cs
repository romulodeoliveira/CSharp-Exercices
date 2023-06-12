using System;

/*
Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.

Exemplo:

Entrada:
5

Saída:
1 1 1
2 4 8
3 9 27
4 16 64
5 25 125
*/


namespace Exercice24
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Saída:");

            for (int i = 1; i <= n; i++)
            {
                int quadrado = i * i;
                int cubo = i * i * i;
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}