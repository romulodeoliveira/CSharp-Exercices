using System;

/*
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

-----------

Exemplo:

-----------

Entrada:
2 2

Saída:
primeiro

-----------

Entrada:
3 -2

Saída:
quarto

-----------

Entrada:
-8 -1

Saída:
terceiro

-----------

Entrada:
-7 1

Saída:
segundo

-----------

Entrada:
0 2

Saída:

*/



namespace Exercice16 {
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                x = int.Parse(input[0]);
                y = int.Parse(input[1]);
                
                if (x == 0 || y == 0) 
                {
                    break;
                }
                
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }

                else if (x < 0 && y < 0) 
                {
                    Console.WriteLine("terceiro");
                }

                else if (x > 0 && y < 0) 
                {
                    Console.WriteLine("quarto");
                }
            }
        }
    }
}