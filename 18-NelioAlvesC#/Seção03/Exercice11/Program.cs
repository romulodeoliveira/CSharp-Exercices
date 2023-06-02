using System;

/*
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

CODIGO \   ESPECIFICAÇÃO   \ PREÇO
1          Cachorro Quente   R$ 4.00
2          X-Salada          R$ 4.50
3          X-Bacon           R$ 5.00
4          Torrada Simples   R$ 2.00
5          Refrigerante      R$ 1.50

Exemplos:

Entrada:
3 2

Saída:
Total: R$ 10.00

Entrada:
2 3

Saída:
Total: R$ 13.50
*/

namespace Exercice11
{
    class Program
    {
        static void Main()
        {
            int codigo, quantidade;
            double preco, total;

            Console.Write("Digite o código do item e a quantidade: ");
            string[] entrada = Console.ReadLine().Split(' ');

            codigo = int.Parse(entrada[0]);
            quantidade = int.Parse(entrada[1]);

            switch (codigo)
            {
                case 1:
                    preco = 4.00;
                    break;
                case 2:
                    preco = 4.50;
                    break;
                case 3:
                    preco = 5.00;
                    break;
                case 4:
                    preco = 2.00;
                    break;
                case 5:
                    preco = 1.50;
                    break;
                default:
                    Console.WriteLine("Código inválido!");
                    return;
            }

            total = preco * quantidade;

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}