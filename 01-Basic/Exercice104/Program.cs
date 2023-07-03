using System;

/*
Escreva um programa C# Sharp para comparar a igualdade de três inteiros e calcular quantos inteiros têm o mesmo valor.

Dados de amostra:
(1,2, 3) -> 0
(1,3,3) -> 2
(3,3,3) -> 3
*/

namespace Exercicie104;

class Program
{
    static void Main(string[] args)
    {
        int[][] numbers = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 1, 3, 3 },
            new int[] { 3, 3, 3 }
        };

        Console.WriteLine($"({numbers[0][0]}, {numbers[0][2]}, {numbers[0][2]}) -> {test(numbers[0][0], numbers[0][1], numbers[0][2])}");
        Console.WriteLine($"({numbers[1][0]}, {numbers[1][2]}, {numbers[1][2]}) -> {test(numbers[1][0], numbers[1][1], numbers[1][2])}");
        Console.WriteLine($"({numbers[2][0]}, {numbers[2][2]}, {numbers[2][2]}) -> {test(numbers[2][0], numbers[2][1], numbers[2][2])}");
        
        static int test(int x, int y, int z)
        {
            if (x == y && y == z)
            {
                return 3;
            }
            
            else if (x != y && y != z && x != z)
            {
                return 0;
            }

            else
            {
                return 2;
            }
        }
    }
}
