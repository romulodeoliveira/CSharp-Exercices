/*
Escreva um programa C# Sharp para inserir um valor adicional em uma matriz (lista classificada).
Dados de teste:
Insira o tamanho da matriz: 3
Insira 3 elementos na matriz em ordem crescente:
elemento - 0: 5
elemento - 1: 7
elemento - 2: 9
Insira o valor a ser inserido: 8
Saída esperada :
A lista de matriz existente é:
5 7 9
Depois de inserir a lista é:
5 7 8 9
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[tamanho];
        Console.WriteLine("Insira os elementos na matriz em ordem crescente:");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Insira o valor a ser inserido: ");
        int valorInserir = Convert.ToInt32(Console.ReadLine());

        InserirValorOrdenado(array, valorInserir);

        Console.WriteLine("\nA lista de matriz existente é:");
        ExibirArray(array);
    }

    static void InserirValorOrdenado(int[] array, int valor)
    {
        int indiceInserir = Array.BinarySearch(array, valor);

        if (indiceInserir < 0)
        {
            indiceInserir = ~indiceInserir;
        }

        Array.Resize(ref array, array.Length + 1);

        for (int i = array.Length - 1; i > indiceInserir; i--)
        {
            array[i] = array[i - 1];
        }

        array[indiceInserir] = valor;
    }

    static void ExibirArray(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.Write($"{elemento} ");
        }
        Console.WriteLine();
    }
}
