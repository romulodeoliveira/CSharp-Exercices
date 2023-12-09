/*
Escreva um programa C# Sharp para encontrar os elementos máximo e mínimo em uma matriz.
Dados de teste:
Insira o número de elementos a serem armazenados na matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 45
elemento - 1: 25
elemento - 2: 21
Saída esperada :
O elemento máximo é: 45 O
elemento mínimo é: 21
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de elementos a serem armazenados na matriz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maximo = EncontrarMaximo(array);
        int minimo = EncontrarMinimo(array);

        // Exibir os resultados
        Console.WriteLine($"\nO elemento máximo é: {maximo}");
        Console.WriteLine($"O elemento mínimo é: {minimo}");
    }

    static int EncontrarMaximo(int[] array)
    {
        int maximo = array[0];

        foreach (int elemento in array)
        {
            if (elemento > maximo)
            {
                maximo = elemento;
            }
        }

        return maximo;
    }

    static int EncontrarMinimo(int[] array)
    {
        int minimo = array[0];

        foreach (int elemento in array)
        {
            if (elemento < minimo)
            {
                minimo = elemento;
            }
        }

        return minimo;
    }
}
