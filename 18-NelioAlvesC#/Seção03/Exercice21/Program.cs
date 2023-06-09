using System;

/*
Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

Exemplo:

Entrada:
3
3 -2
-8 0
0 8

Saída:
-1.5
divisao impossivel
0.0
*/

namespace Exercice21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nDigite o par de números separados por espaço: ");
                string[] valores = Console.ReadLine().Split(' ');
                int numerador = int.Parse(valores[0]);
                int denominador = int.Parse(valores[1]);

                if (denominador != 0)
                {
                    double divisao = (double)numerador / denominador;
                    Console.WriteLine(divisao.ToString("F1"));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}