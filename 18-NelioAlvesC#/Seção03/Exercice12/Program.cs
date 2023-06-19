using System;

/*
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

Exemplos:

Entrada:
25.01

Saída:
Intervalo (25,50]

Entrada:
25.00

Saída:
Intervalo [0,25]

Entrada:
100.00

Saída:
Intervalo (75,100]

Entrada:
-25.02

Saída:
Fora de intervalo
*/

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            string str = Console.ReadLine();

            if (double.TryParse(str, out double numValue))
            {
                if (numValue >= 0 && numValue <= 25)
                {
                    Console.WriteLine("Intervalo (0, 25)");
                }
                else if (numValue > 25 && numValue <= 50)
                {
                    Console.WriteLine("Intervalo (25, 50)");
                }
                else if (numValue > 50 && numValue <= 75)
                {
                    Console.WriteLine("Intervalo (50, 75)");
                }
                else if (numValue > 75 && numValue <= 100)
                {
                    Console.WriteLine("Intervalo (75, 100)");
                }
                else
                {
                    Console.WriteLine("Fora de intervalo");
                }
            }
            else
            {
                Console.WriteLine("Insira um número válido.");
            }
        }
    }
}
