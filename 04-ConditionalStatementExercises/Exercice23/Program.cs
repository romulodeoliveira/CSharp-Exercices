using System;

/*
Escreva um programa em C# Sharp para ler qualquer número de mês inteiro e exibir o número de dias desse mês.

Dados de teste:
7

Saída esperada:
O mês tem 31 dias
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a month number (1 to 12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        int numberOfDays = GetNumberOfDaysInMonth(monthNumber);

        if (numberOfDays != -1)
        {
            Console.WriteLine($"O mês tem {numberOfDays} dias.");
        }
        else
        {
            Console.WriteLine("Mês inválido.");
        }
    }

    static int GetNumberOfDaysInMonth(int monthNumber)
    {
        switch (monthNumber)
        {
            case 1: // Janeiro
            case 3: // Março
            case 5: // Maio
            case 7: // Julho
            case 8: // Agosto
            case 10: // Outubro
            case 12: // Dezembro
                return 31;
            case 4: // Abril
            case 6: // Junho
            case 9: // Setembro
            case 11: // Novembro
                return 30;
            case 2: // Fevereiro
                return 28; // Supondo que não é um ano bissexto
            default:
                return -1; // Mês inválido
        }
    }
}