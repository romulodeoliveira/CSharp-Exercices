using System;

/*
Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
*/

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, 6, 40.0);
            emp1.Print();
        }
    }
}