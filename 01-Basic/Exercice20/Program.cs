using System;

/*
Escreva um programa C# para obter o valor absoluto da diferença entre dois números dados. Retorna o dobro do valor absoluto da diferença se o primeiro número for maior que o segundo número.
*/

namespace Exercice20
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro número: ");
            string v1 = Console.ReadLine();

            System.Console.Write("Digite o segundo número: ");
            string v2 = Console.ReadLine();

            if (int.TryParse(v1, out int n1) && int.TryParse(v2, out int n2))
            {
                int absoluteValue = n1 - n2;
                System.Console.WriteLine($"O valor absoluto da diferença({absoluteValue}) entre {n1} e {n2} é: {Math.Abs(absoluteValue)}");

                if (n1 > n2)
                {
                    System.Console.WriteLine($"Levando em consideração que o primeiro número ({n1}) é maior que o segundo ({n2}), o dobro do valor absoluto da diferença é: {2 * (Math.Abs(absoluteValue))}");
                }
            }

            else
            {
                System.Console.WriteLine("Entrada de dados incorreta. Insira apenas números inteiros.");
            }
        }
    }
}