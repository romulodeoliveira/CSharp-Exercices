using System;

/*
Escreva um programa C# que encontre o prefixo comum mais longo de um array de strings.

Sample Data:
({ "Padas", "Packed", "Pace", "Pacha" }) -> "Pa"
({ "Jacket", "Joint", "Junky", "Jet" }) -> "J"
({ "Bort", "Whang", "Yarder", "Zoonic" }) -> ""
*/

namespace Exercice94;

class Program
{
    static void Main(string[] args)
    {
        string[][] strs =
        {
            new string[] { "Padas", "Packed", "Pace", "Pacha" },
            new string[] { "Jacket", "Joint", "Junky", "Jet" },
            new string[] { "Bort", "Whang", "Yarder", "Zoonic" }
        };

        string prefix1 = Prefix.FindLongestCommonPrefix(strs[0]);
        string prefix2 = Prefix.FindLongestCommonPrefix(strs[1]);
        string prefix3 = Prefix.FindLongestCommonPrefix(strs[2]);

        Console.WriteLine($"Longest common prefix for strings1: {prefix1}");
        Console.WriteLine($"Longest common prefix for strings2: {prefix2}");
        Console.WriteLine($"Longest common prefix for strings3: {prefix3}");
    }
}
