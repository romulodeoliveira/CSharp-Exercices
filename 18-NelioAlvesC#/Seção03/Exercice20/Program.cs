using System;

/*
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.

Exemplo:

Entrada:
3
6.5 4.3 6.2
5.1 4.2 8.1
8.0 9.0 10.0

Saída:
5.7
6.3
9.3
*/

namespace Exercice20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCasos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCasos; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);
                double valor3 = double.Parse(valores[2]);

                double mediaPonderada = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;

                Console.WriteLine(mediaPonderada.ToString("F1"));
            }
        }
    }
}