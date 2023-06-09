﻿using System;

/*
Escreva um programa C# Sharp para encontrar a soma dos ângulos internos (em graus) de um determinado polígono. Insira o número de linha(s) reta(s).

De Wikipedia,
Em geometria, um polígono é uma figura plana que é descrita por um número finito de segmentos de linha reta conectados para formar uma cadeia poligonal fechada ou circuito poligonal. A região do plano sólido, o circuito delimitador ou os dois juntos podem ser chamados de polígonos.
Exemplo de saída:
Insira o número de linhas retas do polígono:
Soma dos ângulos internos (em graus) do referido polígono: -360
*/

namespace Exercice88;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o número de linhas retas do polígono: ");
        int numLines = int.Parse(Console.ReadLine());

        int sumAngles = (numLines - 2) * 180;

        Console.WriteLine($"Soma dos ângulos internos (em graus) do referido polígono: {sumAngles}");
    }
}