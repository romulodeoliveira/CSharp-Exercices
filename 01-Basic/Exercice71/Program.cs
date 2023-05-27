using System;

/*
Escreva um programa C# para verificar se uma determinada string contém duas letras consecutivas semelhantes.

Exemplo de saída:

String original: PHP
Teste para letras semelhantes consecutivas! Falso

String original:
Teste PHHP para letras semelhantes consecutivas! Verdadeiro

Cadeia de caracteres original:
teste PHPP para letras semelhantes consecutivas! Verdadeiro

String original:
Teste PPHP para letras semelhantes consecutivas! Verdadeiro
*/

namespace Exercice71
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma palavra: ");
            string str = Console.ReadLine();

            bool isEquals = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (i != str.Length - 1)
                {
                    if (str[i] == str[i + 1])
                    {
                        isEquals = true;
                    }
                }
            }

            if (isEquals)
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