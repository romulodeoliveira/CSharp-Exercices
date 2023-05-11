using System;

// Escreva um programa C# Sharp para verificar se uma determinada string contém apenas caracteres minúsculos ou maiúsculos.

namespace Exercice69
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            string str1 = str.Replace(" ", "");

            bool containOnlyUpperCase = str1.All(char.IsUpper);
            bool containOnlyLowerCase = str1.All(char.IsLower);

            if (containOnlyUpperCase || containOnlyLowerCase)
            {
                System.Console.WriteLine("Contém apenas letras maiusculas ou minusculas.");
            }

            else
            {
                System.Console.WriteLine("Contem os dois.");
            }
        }
    }
}