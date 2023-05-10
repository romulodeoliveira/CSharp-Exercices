using System;

/*
Escreva um programa C# Sharp para criar uma string codificada a partir de uma determinada string, usando a fórmula especificada.

Substitua todos os 'P' por '9', 'T' por '0', 'S' por '1', 'H' por '6' e 'A' por '8'.

Saída de amostra:
969
J8V81CRI90

*/

namespace Exercice67
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma palavra: ");
            string str1 = Console.ReadLine();
            string str2 = str1.ToUpper();
            str2 = str2.Replace('P', '9');
            str2 = str2.Replace('T', '0');
            str2 = str2.Replace('S', '1');
            str2 = str2.Replace('H', '6');
            str2 = str2.Replace('A', '8');

            System.Console.WriteLine(str1);
            System.Console.WriteLine(str2);
        }
    }
}