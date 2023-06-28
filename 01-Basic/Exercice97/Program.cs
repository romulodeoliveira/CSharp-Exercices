using System;

/*
Escreva um programa C# Sharp para verificar se uma determinada string (ponto flutuante e números negativos incluídos) é numérica ou não. Retorna True se a dita string for numérica caso contrário false.

Sample Data:
("123") -> True
("123.33") -> True
("33/33") -> False
("234234d2") -> False
*/

namespace Exercice97;

class Program
{
    static void Main(string[] args)
    {
        string str = "123";

        bool isAllNumeric = true;

        if (isAllNumeric)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (i != 0)
                {
                    if (!char.IsNumber(str[i]))
                    {
                        isAllNumeric = false;
                        break;
                    }
                }
            }
        }

        Console.WriteLine($"É tudo numérico: {isAllNumeric}");
    }
}