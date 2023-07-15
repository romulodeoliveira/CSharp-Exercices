using System;

/*
Escreva um programa C# Sharp para criar uma string como "aababcabcd" a partir de uma determinada string "abcd".

Sample Input:
"abcd"
"abc"
"a"

Expected Output:
aababcabcd
aababc
a
*/

namespace Exercice30;

class Program
{
    static void Main(string[] args)
    {
        string str = "abcd";

        Console.WriteLine($"{str[0]}{str[0]}{str[1]}{str[0]}{str[1]}{str[2]}{str[0]}{str[1]}{str[2]}{str[3]}");
    }
}