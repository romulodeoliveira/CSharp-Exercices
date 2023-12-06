/*
Escreva um programa C# Sharp para mesclar duas matrizes do mesmo tamanho classificadas em ordem crescente.
Dados de teste:
Insira o número de elementos a serem armazenados na primeira matriz: 3
Insira 3 elementos na matriz:
elemento - 0: 1
elemento - 1: 2
elemento - 2: 3
Insira o número de elementos a serem armazenados na segunda array :3
Insira 3 elementos no array:
elemento - 0 : 1
elemento - 1 : 2
elemento - 2 : 3
Saída esperada :
O array mesclado em ordem crescente é :
1 1 2 2 3 3
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o número de elementos a serem armazenados na primeira matriz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array1 = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento - {i}: ");
            array1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Insira o número de elementos a serem armazenados na segunda matriz: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[] array2 = new int[m];

        for (int i = 0; i < m; i++)
        {
            Console.Write($"Elemento - {i}: ");
            array2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] arrayMesclado = MesclarMatrizes(array1, array2);
        Console.WriteLine("\nO array mesclado em ordem crescente é:");
        ExibirArray(arrayMesclado);
    }

    static int[] MesclarMatrizes(int[] array1, int[] array2)
    {
        int[] arrayMesclado = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] < array2[j])
            {
                arrayMesclado[k++] = array1[i++];
            }
            else
            {
                arrayMesclado[k++] = array2[j++];
            }
        }

        while (i < array1.Length)
        {
            arrayMesclado[k++] = array1[i++];
        }

        while (j < array2.Length)
        {
            arrayMesclado[k++] = array2[j++];
        }

        return arrayMesclado;
    }

    static void ExibirArray(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }
}
