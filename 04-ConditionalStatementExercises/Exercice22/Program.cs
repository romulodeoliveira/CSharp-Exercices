using System;

/*
Escreva um programa em C# Sharp para ler qualquer número de mês inteiro e exibir o nome do mês na palavra.

Dados de teste:
4

Saída esperada :
abril
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a month number (1 to 12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        string monthName = GetMonthName(monthNumber);

        Console.WriteLine("O nome do mês é: " + monthName);
    }

    static string GetMonthName(int monthNumber)
    {
        switch (monthNumber)
        {
            case 1:
                return "janeiro";
            case 2:
                return "fevereiro";
            case 3:
                return "março";
            case 4:
                return "abril";
            case 5:
                return "maio";
            case 6:
                return "junho";
            case 7:
                return "julho";
            case 8:
                return "agosto";
            case 9:
                return "setembro";
            case 10:
                return "outubro";
            case 11:
                return "novembro";
            case 12:
                return "dezembro";
            default:
                return "Mês inválido";
        }
    }
}