using System;

/*
Escreva um programa C# Sharp para verificar se todos os caracteres em uma string são iguais. Retorna true se todos os caracteres da string forem iguais, caso contrário, false.

Sample Data:
("aaa") -> True
("abcd") -> False
("3333") -> True
("2342342") -> False
*/

namespace Exercice96;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "aab";

        bool isEqual = true;

        if (isEqual)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (i != 0)
                {
                    if (str1[i] != str1[i - 1])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
        }

        Console.WriteLine($"É igual: {isEqual}");
    }
}