using System;

/*
Escreva um programa C# Sharp para verificar a comparação de igualdade (valor e tipo) de dois parâmetros. Retorna verdadeiro se forem iguais, caso contrário, falso.

Sample Data:
("AAA", "BBB") -> False
(true, false) -> False
(true, "true") -> False
(10, 10) -> True
*/

namespace Exercice100;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(AreEqual("AAA", "BBB"));
        Console.WriteLine(AreEqual(true, false));
        Console.WriteLine(AreEqual(true, "true"));
        Console.WriteLine(AreEqual(10, 10));
    }

    static bool AreEqual(object param1, object param2)
    {
        return param1.Equals(param2) && param1.GetType() == param2.GetType();
    }
}
