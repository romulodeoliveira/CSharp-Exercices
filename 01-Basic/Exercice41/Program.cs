using System;

/*
Escreva um programa C# para verificar se uma determinada string contém o caractere 'w' entre 1 e 3 vezes.

Dados de teste:
Insira uma string (contém pelo menos um caractere 'w'): w3resource
Teste se a string contém o caractere 'w' entre 1 e 3 vezes:
Exemplo de saída
Verdadeiro
*/

namespace Exercice41
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();
            int quantity = str.Count(a => a == 'w');

            if (quantity > 0 && quantity <= 3)
            {
                System.Console.WriteLine("Verdadeiro");
            }

            else
            {
                System.Console.WriteLine("Falso");
            }
        }
    }
}