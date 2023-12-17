/*
Escreva um programa C# Sharp para encontrar o segundo menor elemento em uma matriz.
Dados de teste:
Insira o tamanho da matriz: 5
Insira 5 elementos na matriz (o valor deve ser <9999):
elemento - 0: 0
elemento - 1: 9
elemento - 2: 4
elemento - 3: 6
elemento - 4: 5
esperado Saída :
O segundo menor elemento da matriz é: 4
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira o tamanho da matriz: ");
        int tamanho = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[tamanho];
        Console.WriteLine("Insira os elementos na matriz (o valor deve ser < 9999):");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"elemento - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int segundoMenor = EncontrarSegundoMenor(array);

        Console.WriteLine($"\nO segundo menor elemento na matriz é: {segundoMenor}");
    }

    static int EncontrarSegundoMenor(int[] array)
    {
        if (array.Length < 2)
        {
            Console.WriteLine("A matriz deve ter pelo menos dois elementos.");
            return -1;
        }

        int menor = int.MaxValue;
        int segundoMenor = int.MaxValue;

        foreach (int elemento in array)
        {
            if (elemento < menor)
            {
                segundoMenor = menor;
                menor = elemento;
            }
            else if (elemento < segundoMenor && elemento != menor)
            {
                segundoMenor = elemento;
            }
        }

        return segundoMenor;
    }
}
