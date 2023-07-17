using System;

/*
Escreva um programa C# Sharp para encontrar a elegibilidade de admissão para um curso profissional com base nos seguintes critérios:

Notas em matemática >=65
Notas em física >=55
Notas em química>=50
Total nas três disciplinas >=180
ou
Total em Matemática e Disciplinas >=140

Dados do Teste :
Informe as notas obtidas em Física :65
Informe as notas obtidas em Química :51
Informe as notas obtidas em Matemática :72

Resultado Esperado :
O candidato é elegível para admissão.
*/

namespace Exercice10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe as notas obtidas em Física: ");
        int notaFisica = int.Parse(Console.ReadLine());

        Console.Write("Informe as notas obtidas em Química: ");
        int notaQuimica = int.Parse(Console.ReadLine());

        Console.Write("Informe as notas obtidas em Matemática: ");
        int notaMatematica = int.Parse(Console.ReadLine());

        int totalNotas = notaFisica + notaQuimica + notaMatematica;

        if (notaMatematica >= 65 && notaFisica >= 55 && notaQuimica >= 50 && totalNotas >= 180)
        {
            Console.WriteLine("O candidato é elegível para admissão.");
        }
        else if (totalNotas >= 140)
        {
            Console.WriteLine("O candidato é elegível para admissão.");
        }
        else
        {
            Console.WriteLine("O candidato não é elegível para admissão.");
        }
    }
}
