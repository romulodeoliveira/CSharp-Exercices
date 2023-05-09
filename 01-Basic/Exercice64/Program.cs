using System;

// Escreva um programa C# Sharp para obter o nome do arquivo (incluindo a extensão) de um determinado caminho.

namespace Exercice64
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "./01-Basic/Exercice64/HelloWorld.cs";
            string extension = Path.GetExtension(path);

            System.Console.WriteLine($"A extensão é: {extension}");
        }
    }
}