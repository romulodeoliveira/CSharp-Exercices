using System;

/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

Exemplo:

Entrada:
5
14
123
10
-25
32

Saída:
2 in
3 out
*/

namespace Exercice19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma quantidade: ");
            int num = int.Parse(Console.ReadLine());

            int inside = 0;
            int outside = 0;

            for (int i = 0; i < num; i++)
            {
                System.Console.Write("Digite um número: ");
                int opt = int.Parse(Console.ReadLine());

                if (opt >= 10 && opt <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            System.Console.WriteLine($"\nDentro: {inside}\nFora: {outside}");
        }
    }
}