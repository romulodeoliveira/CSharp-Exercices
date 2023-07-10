using System;

/*
Escreva um programa C# Sharp para verificar se uma determinada string contém entre 2 e 4 caracteres 'z'.

Exemplo de entrada :
"frizz"
"zane"
"Zazz"
"false"
"zzzz"
"ZZZZ"

Saída esperada :
Verdadeiro
Falso
Verdadeiro
Falso
Verdadeiro
Verdadeiro
*/

namespace Exercice22;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckZCount("frizz"));
        Console.WriteLine(CheckZCount("zane"));
        Console.WriteLine(CheckZCount("Zazz"));
        Console.WriteLine(CheckZCount("false"));
        Console.WriteLine(CheckZCount("zzzz"));
        Console.WriteLine(CheckZCount("ZZZZ"));
    }

    static bool CheckZCount(string input)
    {
        int count = 0;

        foreach (char c in input)
        {
            if (c == 'z' || c == 'Z')
            {
                count++;
            }
        }

        return count >= 2 && count <= 4;
    }
}
