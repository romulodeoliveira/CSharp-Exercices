using System;

/*
Escreva um programa C# Sharp que receba uma idade (por exemplo, 20) como entrada e imprima algo como "Você parece ter mais de 20 anos".

Dados do teste:
Digite sua idade - 25
Resultado esperado:
Você parece ter mais de 25 anos
*/

namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite sua idade: ");
            string age = Console.ReadLine();

            if (int.TryParse(age, out int ageInt))
            {
                System.Console.WriteLine($"Você parece ter mais de {ageInt} anos.");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}