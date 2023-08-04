using System;

/*
Escreva um programa em C# Sharp que seja um programa orientado por menus para calcular a área de várias formas geométricas.

Dados de teste:
Insira sua escolha: 1
Insira o raio do círculo: 5

Saída esperada :
A área é: 78,500000
*/

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calcular área do círculo");
            Console.WriteLine("2. Sair");
            Console.Write("Insira sua escolha: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalcularAreaCirculo();
                    break;
                case 2:
                    Console.WriteLine("Encerrando o programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CalcularAreaCirculo()
    {
        Console.Write("Insira o raio do círculo: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine($"A área é: {area.ToString("F6")}");
    }
}