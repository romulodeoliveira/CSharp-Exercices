using System;

/*
Escreva um programa C# para verificar o valor mais próximo de 20 de dois inteiros fornecidos e retornar 0 se dois números forem iguais.

Dados de teste:
Primeiro inteiro de entrada:
15
Segundo inteiro de entrada:
12
Saída de amostra
15
*/

namespace Exercice40
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Primeiro inteiro de entrada: ");
            string str1 = Console.ReadLine();

            System.Console.Write("Segundo inteiro de entrada: ");
            string str2 = Console.ReadLine();

            if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2))
            {
                if (num1 == num2)
                {
                    Console.WriteLine("0");
                }
                else if (Math.Abs(num1 - 20) < Math.Abs(num2 - 20))
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}