using System;

/*
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.

Fórmula da área: area = π . raio2

Considere o valor de π = 3.14159
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o valor do raio: ");
            string str = Console.ReadLine();

            if (double.TryParse(str, out double raio))
            {
                double area = 3.14159 * Math.Pow(raio, 2);
                System.Console.WriteLine(area);
            }

            else
            {
                System.Console.WriteLine("Entrada de dados inválida.");
            }
        }
    }
}