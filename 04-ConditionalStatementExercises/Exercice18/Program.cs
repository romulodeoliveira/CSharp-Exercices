using System;

/*
Escreva um programa em C# Sharp para calcular e imprimir a conta de luz de um determinado cliente. O ID do cliente, nome e unidade consumida pelo usuário devem ser retirados do teclado e exibir o valor total a pagar ao cliente. A cobrança é a seguinte:

Unidade	Carga/unidade
até 199	@1,20
200 e acima, mas menos de 400	@1,50
400 e acima, mas menos de 600	@1,80
600 e acima	@2,00

Se a conta exceder Rs. 400, será cobrada uma sobretaxa de 15% e a conta mínima deve ser de Rs. 100/-

Dados de teste:
1001
James
800
Saída esperada :
ID do cliente: 1001
Nome do cliente: unidade James
consumida: 800
Valor cobrados @Rs. 2,00 por unidade: 1600,00
Valor da sobretaxa: 240,00
Valor líquido pago pelo cliente: 1840,00
*/

namespace Exercice18;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o ID do cliente: ");
        int customerId = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do cliente: ");
        string customerName = Console.ReadLine();

        Console.Write("Digite a quantidade de unidades consumidas pelo cliente: ");
        int unitsConsumed = int.Parse(Console.ReadLine());

        double chargePerUnit;
        if (unitsConsumed <= 199)
        {
            chargePerUnit = 1.20;
        }
        else if (unitsConsumed >= 200 && unitsConsumed < 400)
        {
            chargePerUnit = 1.50;
        }
        else if (unitsConsumed >= 400 && unitsConsumed < 600)
        {
            chargePerUnit = 1.80;
        }
        else
        {
            chargePerUnit = 2.00;
        }

        double totalAmount = unitsConsumed * chargePerUnit;

        if (totalAmount > 400)
        {
            double surcharge = totalAmount * 0.15;
            totalAmount += surcharge;
        }
        else if (totalAmount < 100)
        {
            totalAmount = 100;
        }

        Console.WriteLine($"\nID do cliente: {customerId}");
        Console.WriteLine($"Nome do cliente: {customerName}");
        Console.WriteLine($"Unidades consumidas: {unitsConsumed}");
        Console.WriteLine($"Valor cobrado @R$ {chargePerUnit:0.00} por unidade: R$ {totalAmount:0.00}");
    }
}
