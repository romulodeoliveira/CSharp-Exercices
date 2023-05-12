using System;

/*
Escreva um programa C# Sharp para verificar um determinado inteiro e retornar true se estiver dentro de 10 de 100 ou 200.

Entrada de amostra :
103
90
89

Saída Esperada :
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                System.Console.WriteLine("Dentro de 10");
            }

            else if (num < 100)
            {
                System.Console.WriteLine("Dentro de 100");
            }

            else if (num < 200)
            {
                System.Console.WriteLine("Dentro de 200");
            }

            else
            {
                System.Console.WriteLine("Falso");
            }
        }
    }
}