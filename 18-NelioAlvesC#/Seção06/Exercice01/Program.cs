using System;

/*
Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.

Exemplo:

Entrada:
3
1.72
1.56
1.80

Saída:
AVERAGE HEIGHT = 1.69
*/

namespace Exercice01;

class Program
{
    static void Main(string[] args)
    {
        Average a = new Average();

        Console.Write("Entrada: ");
        int numberOfIterations = int.Parse(Console.ReadLine());
        double[] heights = new double[numberOfIterations];
        
        for (int i = 0; i < numberOfIterations; i++)
        {
            Console.Write("Altura: ");
            heights[i] = double.Parse(Console.ReadLine());
        }
        
        
        double averageHeight = a.Height(numberOfIterations, heights);
        Console.WriteLine($"AVERAGE HEIGHT = {averageHeight.ToString("F2")}");
    }
}