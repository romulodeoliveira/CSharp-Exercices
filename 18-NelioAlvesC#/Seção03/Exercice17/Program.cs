using System;

/*
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

Exemplo:

Entrada:
8
1
7
2
2
4

Saída:
MUITO OBRIGADO
Alcool: 1
Gasolina: 2
Diesel: 0
*/

namespace Exercice17
{
    class Program
    {
        static void Main(string[] args) 
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("Informe o código do combustível abastecido:");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Fim");

            int codigo = 0;
            while (codigo != 4)
            {
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1)
                {
                    alcool++;
                }
                else if (codigo == 2)
                {
                    gasolina++;
                }
                else if (codigo == 3)
                {
                    diesel++;
                }
                else if (codigo == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Código inválido. Por favor, informe um código válido.");
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}