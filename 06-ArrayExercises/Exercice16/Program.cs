/*
Escreva um programa C# Sharp para encontrar o segundo maior elemento em uma matriz.
Dados de teste:
Insira o tamanho da matriz: 5
Insira 5 elementos na matriz:
elemento - 0: 2
elementos - 1: 9
elementos - 2: 1
elemento - 3: 4
elementos - 4: 6
Saída esperada :
O segundo maior elemento em a matriz é: 6
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[tamanho];
        Console.WriteLine("Insira os elementos na matriz:");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int segundoMaior = EncontrarSegundoMaior(array);

        Console.WriteLine($"\nO segundo maior elemento na matriz é: {segundoMaior}");
    }

    static int EncontrarSegundoMaior(int[] array)
    {
        if (array.Length < 2)
        {
            Console.WriteLine("A matriz deve ter pelo menos dois elementos.");
            return -1;
        }

        Array.Sort(array);
        return array[array.Length - 2];
    }
}
