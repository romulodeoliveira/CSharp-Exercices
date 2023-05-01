using System;

/*
Escreva um programa C# para verificar se "HP" aparece na segunda posição em uma string e retorna a string sem "HP".

Test Data: PHP Tutorial
Sample Output:
P Tutorial
*/

namespace Exercice37
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            string newStr = str.Replace("HP", "");

            System.Console.WriteLine(newStr);
        }
    }
}