using System;

/*
Escreva um programa C# Sharp para inverter um valor booleano.

Exemplo de saída:
Valor original: Falso
Valor reverso: Verdadeiro
Valor original: Verdadeiro
Valor reverso: Falso
*/

namespace Exercice87;

class Program
{
    static void Main(string[] args)
    {
        bool a = false;

        Console.WriteLine("Valor original: " + a);
        Console.WriteLine("Valor reverso: " + !a);

        a = true;

        Console.WriteLine("Valor original: " + a);
        Console.WriteLine("Valor reverso: " + !a);
    }
}