using System;

/*
Escreva um programa C# Sharp para calcular a raiz quadrada de um determinado número. Não use nenhuma função interna, retorne parte inteira do resultado.

Sample Data:
(120) -> 10
(225) -> 15
(335) -> 18
*/

namespace Exercice93;

class Program
{
    static void Main(string[] args)
    {
        int number = 225;

        int squareRoot = Math.SquareRoot(number);

        Console.WriteLine($"A raiz quadrada de {number} é {squareRoot}");
    }
}
