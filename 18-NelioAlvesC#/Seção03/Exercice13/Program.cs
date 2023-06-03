using System;

/*
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

Exemplos:

Entrada:
4.5 -2.2

Saída:
Q4

Entrada:
0.1 0.1

Saída:
Q1

Entrada:
0.0 0.0

Saída:
Origem
*/

namespace Exercice13
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Coordenadas: ");
            string[] coordenadas = Console.ReadLine().Split(' ');

            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}