/*
Escreva um programa C# Sharp para inserir outro valor na matriz (lista não classificada).
Dados de teste:
Insira o tamanho da matriz: 4
Insira 4 elementos na matriz em ordem crescente:
elemento - 0: 1
elemento - 1: 8
elemento - 2: 7
elemento - 3: 10
Insira o valor a ser inserido: 5
Insira o Posição, onde o valor a ser inserido é: 2
Saída Esperada :
A lista atual do array:
1 8 7 10
Após inserir o elemento a nova lista é:
1 5 8 7 10
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

        Console.Write("Insira a posição onde o valor será inserido: ");
        int posicaoInserir = Convert.ToInt32(Console.ReadLine());

        InserirValorNaPosicao(array, valorInserir, posicaoInserir);

        Console.WriteLine("\nA lista atual do array:");
        ExibirArray(array);
    }

    static void InserirValorNaPosicao(int[] array, int valor, int posicao)
    {
        Array.Resize(ref array, array.Length + 1);

        for (int i = array.Length - 1; i > posicao; i--)
        {
            array[i] = array[i - 1];
        }

        array[posicao] = valor;
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
