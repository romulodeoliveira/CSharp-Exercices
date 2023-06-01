using System;

/*
Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            Products p1 = new Products(1, 2, 5.0);
            p1.Print();

            Products p2 = new Products(2, 3, 7.5);
            p2.Print();
        }
    }
}