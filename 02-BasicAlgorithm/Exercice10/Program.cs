using System;

/*
Escreva um programa C# Sharp para verificar se um determinado número positivo é um múltiplo de 3 ou um múltiplo de 7.

Exemplo de Entrada :
3
14
12
37

Saída Esperada :
Verdadeiro
Verdadeiro
Verdadeiro
Falso
*/

namespace Exercice10;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[] { -5, 2, 10, -7, 0, 21, 30, -21, -30 };

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0 && IsMultipleOf3(nums[i]))
            {
                Console.WriteLine(true);
            }
            else if (nums[i] > 0 && IsMultipleOf7(nums[i]))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
    
    static bool IsMultipleOf3(int number)
    {
        return number % 3 == 0;
    }

    static bool IsMultipleOf7(int number)
    {
        return number % 7 == 0;
    }
}