using System;

/*
Escreva um programa C# Sharp que receba um número e uma largura também um número, como entrada e, em seguida, exiba um triângulo dessa largura, usando esse número.

Dados de teste
Insira um número: 6
Insira a largura desejada: 6
Saída esperada :

666666                                                      
66666                                                           
6666                                                                  
666                                                        
66                                                                  
6
*/

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Insira a largura desejada: ");
            int largura = int.Parse(Console.ReadLine());

            for (int i = largura; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(numero);
                }

                Console.WriteLine();
            }
        }
    }
}