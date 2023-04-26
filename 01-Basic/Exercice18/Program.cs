using System;

/*
Escreva um programa C# para verificar dois inteiros fornecidos e retornar true se um for negativo e o outro for positivo.

Exemplo de saída:

Insira o primeiro inteiro:
-5
Insira o segundo inteiro:
25
Verifique se um é negativo e o outro é positivo:
Verdadeiro
*/

namespace Exercice18
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Insira o primeiro inteiro: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Insira o segundo inteiro: ");
            string v2 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2))
            {
                if (n1 >= 0 && n2 < 0 || n2 >= 0 && n1 < 0)
                {
                    System.Console.WriteLine("Verdadeiro!");
                }

                else
                {
                    System.Console.WriteLine("Falso!");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados inválida. Insira apenas números inteiros.");
            }
        }
    }
}