﻿using System;

/*
Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. 

Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.

Exemplos:

Entrada:
3002.00

Saída:
R$ 80.36

Entrada:
1701.12

Saída:
Isento

Entrada:
4520.00

Saída:
R$ 355.60
*/

namespace Exercice14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite seu salário: R$ ");
            double salary = double.Parse(Console.ReadLine());

            if (salary > 2000)
            {
                if (salary > 3000)
                {
                    System.Console.WriteLine($"Imposto: {(8 * 1000 / 100) + (18 * (salary - 3000) / 100)}");
                }

                else
                {
                    System.Console.WriteLine($"Imposto: {8 * (salary - 2000) / 100}");
                }
            }
            else
            {
                System.Console.WriteLine("Isento.");
            }
        }
    }
}