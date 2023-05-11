using System;

/*
Escreva um programa C# Sharp para calcular a soma dos dois valores inteiros fornecidos. Se os dois valores forem iguais, retorne o triplo da soma.

Entrada de amostra :
1, 2
3, 2
2, 2

Saída esperada :
3
5
12
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro número: ");
            string str1 = Console.ReadLine();

            System.Console.Write("Insira o segundo número: ");
            string str2 = Console.ReadLine();

            if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2))
            {
                if (num1 != num2)
                {
                    System.Console.WriteLine(num1 + num2);
                }

                else
                {
                    System.Console.WriteLine((num1 + num2) * 3);
                }
            }

            else
            {
                System.Console.WriteLine("Insira apenas números inteiros.");
            }
        }
    }
}