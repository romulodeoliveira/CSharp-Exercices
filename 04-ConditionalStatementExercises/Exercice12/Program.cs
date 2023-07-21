using System;

/*
Escreva um programa em C# Sharp para ler o número do rolo, o nome e as notas de três disciplinas e calcular o total, a porcentagem e a divisão.

Dados do teste:
Insira o número do rolo do aluno: 784
Insira o nome do aluno: James
Insira as notas de física, química e aplicação de computador: 70 80 90

Saída esperada :
Roll No: 784
Nome do aluno: James
Notas em Física : 70
Notas em Química : 80
Notas em Aplicação de Computador : 90
Notas Total = 240
Porcentagem = 80,00
Divisão = Primeiro
*/

namespace Exercice12;

class Program
{
    static void Main(string[] args)
    {
        int rollNo;
        string studentName;
        double physicsGrade, chemistryGrade, computerAppGrade;

        Console.Write("Insira o número do rolo do aluno: ");
        rollNo = int.Parse(Console.ReadLine());

        Console.Write("Insira o nome do aluno: ");
        studentName = Console.ReadLine();

        Console.Write("Insira as notas de Física, Química e Aplicação de Computador (separadas por espaço): ");
        string[] grades = Console.ReadLine().Split(' ');

        physicsGrade = double.Parse(grades[0]);
        chemistryGrade = double.Parse(grades[1]);
        computerAppGrade = double.Parse(grades[2]);

        double totalGrades = physicsGrade + chemistryGrade + computerAppGrade;

        double percentage = (totalGrades / 300) * 100;

        string division;
        if (percentage >= 60)
        {
            division = "Primeiro";
        }
        
        else if (percentage >= 40)
        {
            division = "Segundo";
        }
        
        else
        {
            division = "Terceiro";
        }

        Console.WriteLine($"Roll No: {rollNo}");
        Console.WriteLine($"Nome do aluno: {studentName}");
        Console.WriteLine($"Notas em Física: {physicsGrade}");
        Console.WriteLine($"Notas em Química: {chemistryGrade}");
        Console.WriteLine($"Notas em Aplicação de Computador: {computerAppGrade}");
        Console.WriteLine($"Notas Total = {totalGrades}");
        Console.WriteLine($"Porcentagem = {percentage:F2}");
        Console.WriteLine($"Divisão = {division}");
    }
}
