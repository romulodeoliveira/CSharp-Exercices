/*
Escreva um programa C# Sharp para calcular lucros e perdas em uma transação.

Dados de teste:
500 700

Saída esperada :
Você pode reservar o valor do lucro: 200
*/

using System;

namespace Exercice17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de compra: ");
            if (double.TryParse(Console.ReadLine(), out double buyingPrice))
            {
                Console.Write("Digite o valor de venda: ");
                if (double.TryParse(Console.ReadLine(), out double sellingPrice))
                {
                    double profit = sellingPrice - buyingPrice;

                    if (profit >= 0)
                    {
                        Console.WriteLine($"Você pode reservar o valor do lucro: {profit}");
                    }
                    else
                    {
                        Console.WriteLine($"Você teve uma perda de: {Math.Abs(profit)}");
                    }
                }
                else
                {
                    Console.WriteLine("Valor de venda inválido. Por favor, insira um valor numérico válido.");
                }
            }
            else
            {
                Console.WriteLine("Valor de compra inválido. Por favor, insira um valor numérico válido.");
            }
        }
    }
}
