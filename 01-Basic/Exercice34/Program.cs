using System;

/*
Escreva um programa C# para verificar se uma string começa com uma palavra especificada.

Nota: suponha que a frase comece com "Olá"
Dados de amostra: string1 = "Olá, como vai você?"
Resultado: Olá.
Saída de amostra:
Insira uma string: Olá, tudo bem?
Verdadeiro
*/

namespace Exercice34
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma mensagem: ");
            string str = Console.ReadLine();

            string[] strSplit = str.Split(" ");

            if (strSplit[0] == "Olá" || strSplit[0] == "Ola" || strSplit[0] == "olá" || strSplit[0] == "ola" || strSplit[0] == "Olá!" || strSplit[0] == "Ola!" || strSplit[0] == "olá!" || strSplit[0] == "ola!" || strSplit[0] == "Olá," || strSplit[0] == "Ola," || strSplit[0] == "olá," || strSplit[0] == "ola,")
            {
                System.Console.WriteLine("Olá! tudo bem?");
            }

            else
            {
                System.Console.WriteLine("C#");
            }
        }
    }
}
