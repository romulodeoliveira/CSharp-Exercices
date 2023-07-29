/*
Escreva um programa em C# Sharp para aceitar uma nota e declarar a descrição equivalente:

Nota	Descrição
E	Excelente
V	Muito bom
G	Bom
A	Média
F	Falhar

Dados do teste:
Insira a nota:a
Saída esperada :
Você escolheu: Média
*/

using System;

namespace GradeDescription;
    
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a nota: ");
        char grade = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        string description;
        switch (grade)
        {
            case 'e':
                description = "Excelente";
                break;
            case 'v':
                description = "Muito bom";
                break;
            case 'g':
                description = "Bom";
                break;
            case 'a':
                description = "Média";
                break;
            case 'f':
                description = "Falhar";
                break;
            default:
                description = "Nota inválida";
                break;
        }

        Console.WriteLine($"Você escolheu: {description}");
    }
}
