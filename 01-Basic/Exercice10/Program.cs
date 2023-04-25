using System;

/*
Escreva um programa C# Sharp que receba três números (x,y,z) como entrada e imprima a saída de (x+y).z e xy + yz. 

Dados de teste: 

Digite o primeiro número - 5
Digite segundo número - 6
Insira o terceiro número - 7

Saída esperada:
Resultado dos números especificados 5, 6 e 7, (x+y).z é 77 ​​e xy + yz é 72
*/

namespace Exercice10
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro número: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Digite o segundo número: ");
            string v2 = Console.ReadLine();

            System.Console.Write("Digite o terceiro número: ");
            string v3 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2) && int.TryParse(v3, out int n3))
            {
                System.Console.WriteLine($"Números informados: {n1}, {n2} e {n3}");
                System.Console.WriteLine($"({n1} + {n2}) x {n3} = {(n1 + n2) * n3}");
                System.Console.WriteLine($"{n1}{n2} + {n2}{n3} = {(n1 * n2) + (n2 * n3)}");
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }

        }
    }
}