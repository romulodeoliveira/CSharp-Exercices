using System;

/*
Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Digite o primeiro número: ");
            string firstVariable = Console.ReadLine();

            System.Console.WriteLine("Digite o segundo número: ");
            string secondVariable = Console.ReadLine();

            if (int.TryParse(firstVariable, out int firstNumber) && int.TryParse(secondVariable, out int secondNumber))
            {
                System.Console.WriteLine($"Você digitou {firstNumber} e {secondNumber}");
                System.Console.WriteLine($"A soma dos dois é {firstNumber + secondNumber}");
            }

            else
            {
                System.Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
            }
        }
    }
}