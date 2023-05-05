using System;

/*
Escreva um programa C# para verificar se uma determinada string é um palíndromo ou não.
Exemplo de amostra:
Para 'aaa' a saída deve ser true
Para 'abcd' a saída deve ser false
*/

namespace Exercice56
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();

            char[] chars = str.ToCharArray();
            char[] reversedChars = new char[chars.Length];

            int i = str.Length - 1;
            int j = 0;

            while (i >= 0)
            {
                reversedChars[j] = chars[i];

                i--;
                j++;
            }

            string reversedStr = new string(reversedChars);

            if (str == reversedStr)
            {
                System.Console.WriteLine($"Verdadeiro: {reversedStr}");
            }

            else
            {
                System.Console.WriteLine($"Falso: {reversedStr}");
            }
        }
    }
}