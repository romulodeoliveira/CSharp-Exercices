using System;

/*
Escreva um programa C# e calcule a soma dos dígitos de um inteiro.

Exemplo de Saída:
Insira um número (inteiro): 12
Soma dos dígitos do referido inteiro: 3

*/

namespace Exercice27
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira um número: ");
            string v1 = Console.ReadLine();

            int cont = 0;
            int i = 0;
            int total = 0;

            while (cont < v1.Length)
            {

                if (int.TryParse(v1[i].ToString(), out int n1))
                {
                    System.Console.WriteLine($"Índice {i} = {n1}");
                }

                else
                {
                    System.Console.WriteLine("Entrada de dados inválida. Insira apenas números inteiros.");
                }

                total += n1;

                i++;
                cont++;
            }

            System.Console.WriteLine($"Total = {total}");

            /*
            for (int i = 0; i < v1.Length; i++)
            {
                System.Console.WriteLine(v1.ToString()[i]);
            } 
            */
        }
    }
}