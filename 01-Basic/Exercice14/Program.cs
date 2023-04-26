using System;

/*
Escreva um programa C# para converter de graus Celsius para Kelvin e Fahrenheit.

Dados de teste:
Digite a quantidade de celsius: 30
Saída esperada:
Kelvin = 303
Fahrenheit = 86
*/

namespace Exercice14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite a temperatura em celsius: ");
            string v1 = Console.ReadLine();

            if (int.TryParse(v1, out int n1))
            {

                System.Console.WriteLine($"Fahrenheit = {(n1 * 9 / 5) + 32}");

                System.Console.WriteLine($"Kelvin = {n1 + 273.15}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}