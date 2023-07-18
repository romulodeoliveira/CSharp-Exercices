using System;

/*
Escreva um programa C# Sharp para calcular a raiz da equação quadrática.

Dados de teste:
Insira o valor de a: 1
Insira o valor de b: 5
Insira o valor de c: 7

Saída esperada :
As raízes são imaginárias;
Nenhuma solução.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o valor de a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Informe o valor de b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Informe o valor de c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"As raízes são: {root1} e {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"A única raiz é: {root}");
        }
        else
        {
            Console.WriteLine("As raízes são imaginárias; nenhuma solução.");
        }
    }
}
