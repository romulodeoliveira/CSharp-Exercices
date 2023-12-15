/*
Escreva um programa C# Sharp para excluir um elemento na posição desejada de uma matriz.
Dados de teste:
Insira o tamanho da matriz: 5
Insira 5 elementos na matriz em ordem crescente:
elemento - 0: 1
elemento - 1: 2
elemento - 2: 3
elemento - 3: 4
elemento - 4: 5
Insira a posição para onde deletar: 3
Saída Esperada :
A nova lista é: 1 2 4 5
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

        Console.Write("Insira a posição para deletar: ");
        int posicaoDeletar = Convert.ToInt32(Console.ReadLine());

        ExcluirElementoNaPosicao(array, posicaoDeletar);

        Console.WriteLine("\nA nova lista é:");
        ExibirArray(array);
    }

    static void ExcluirElementoNaPosicao(int[] array, int posicao)
    {
        if (posicao >= 0 && posicao < array.Length)
        {
            for (int i = posicao; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);
        }
        else
        {
            Console.WriteLine("Posição inválida.");
        }
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
