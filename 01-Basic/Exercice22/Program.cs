using System;

/*
Escreva um programa C# para verificar se um determinado número inteiro está dentro de 20 de 100 ou 200.
*/

namespace Exercice22
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um número: ");
            string str = Console.ReadLine();

            if (int.TryParse(str, out int num))
            {
                if (num <= 20)
                {
                    System.Console.WriteLine("Está dentro de 20!");
                }

                else if (num <= 100)
                {
                    System.Console.WriteLine("Está dentro de 100!");
                }

                else if (num <= 200)
                {
                    System.Console.WriteLine("Está dentro de 200!");
                }

                else
                {
                    if (num < 200)
                    {
                        System.Console.WriteLine("É maior que 200!");
                    }

                    else
                    {
                        System.Console.WriteLine("É negativo!");
                    }
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros");
            }
        }
    }
}