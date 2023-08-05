using System;

/*
Escreva um programa em C# Sharp que seja um programa dirigido por menus para executar um cálculo simples.

Data do teste e saída esperada
Digite o primeiro inteiro: 10
Digite o segundo inteiro: 2

Aqui estão as opções:
1-Adição.
2-Subtração.
3- Multiplicação.
4-Divisão.
5- Sair.

Insira sua escolha: 3
A multiplicação de 10 e 2 é: 20
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Aqui estão as opções:");
            Console.WriteLine("1-Adição.");
            Console.WriteLine("2-Subtração.");
            Console.WriteLine("3-Multiplicação.");
            Console.WriteLine("4-Divisão.");
            Console.WriteLine("5-Sair.");
            Console.Write("Insira sua escolha: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"A adição de {num1} e {num2} é: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"A subtração de {num1} e {num2} é: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"A multiplicação de {num1} e {num2} é: {num1 * num2}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        double divisao = (double)num1 / num2;
                        Console.WriteLine($"A divisão de {num1} por {num2} é: {divisao}");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Encerrando o programa.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
