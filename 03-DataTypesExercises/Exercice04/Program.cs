using System;

/*
Escreva um programa C# Sharp que receba dois números como entrada e execute uma operação (+,-,*,x,/) neles e exiba o resultado dessa operação.

Dados de teste
Insira o primeiro número: 20
Operação de entrada: -
Insira o segundo número: 12
Saída esperada :
20 - 12 = 8
*/

namespace Exercice04;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira o primeiro número: ");
        double number1 = double.Parse(Console.ReadLine());

        Console.Write("Operação de entrada (+, -, *, /): ");
        char operation = char.Parse(Console.ReadLine());

        Console.Write("Insira o segundo número: ");
        double number2 = double.Parse(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
            case 'x':
                result = number1 * number2;
                break;
            case '/':
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        Console.WriteLine($"{number1} {operation} {number2} = {result}");
    }
}
