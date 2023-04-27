using System;

/*
Escreva um programa C# para encontrar o tamanho de um arquivo especificado em bytes.
Exemplo de Saída:
Tamanho de um arquivo: 31
*/

namespace Exercice29
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "01-Basic/Exercice29/file.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            double lengthFile = fileInfo.Length;

            System.Console.WriteLine($"Tamanho do arquivo: {lengthFile} bytes.");
        }
    }
}