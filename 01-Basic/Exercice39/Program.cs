using System;

/*
Escreva um programa C# para encontrar o maior e o menor valor de três valores inteiros.

Dados de teste:
Insira o primeiro inteiro:
15
Insira o segundo inteiro:
25
Insira o terceiro inteiro:
30
Exemplo de saída
Maior de três: 30
Menor de três: 15
*/

namespace Exercice39
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite três números separados por espaços: ");
            string input = Console.ReadLine();
            string[] variable = input.Split(" ");
            int[] num = new int[3];
            int lowerValue = int.MaxValue;
            int highestvalue = int.MinValue;

            if (variable.Length == 3 && int.TryParse(variable[0], out num[0]) && int.TryParse(variable[1], out num[1]) && int.TryParse(variable[2], out num[2]))
            {
                for (int i = 0; i < num.Length; i++)
                {

                    if (num[i] > highestvalue)
                    {
                        highestvalue = num[i];
                    }

                    if (num[i] < lowerValue)
                    {
                        lowerValue = num[i];
                    }
                }
                System.Console.WriteLine($"Maior de três: {highestvalue}");
                System.Console.WriteLine($"Menor de três: {lowerValue}");
            }

            else
            {
                System.Console.WriteLine($"Você precisa fornecer três números inteiros válidos.");
            }
        }
    }
}