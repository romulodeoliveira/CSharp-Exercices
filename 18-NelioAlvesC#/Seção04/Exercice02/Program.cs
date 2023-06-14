using System;

/*
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

Exemplo:

Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00

Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00

Salário médio = 6500.00
*/

namespace Exercice02;

class Program
{
    static void Main(string[] args)
    {
        Form employee1 = new Form("Joaozinho", 6300.00);
        Form employee2 = new Form("Pedrinho", 6700.00);

        Console.WriteLine($"A média salarial é de R$ {Form.AverageSalary(employee1, employee2):F2}");
    }
}