using System;

/*
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

Exemplo:

Dados da primeira pessoa:
Nome: Maria
Idade: 17

Dados da segunda pessoa:
Nome: Joao
Idade: 16

Pessoa mais velha: Maria
*/

namespace Exercice01;

class Program
{
    public static void Main(string[] args)
    {
        Form person1 = new Form("Joazinho", 12);
        Form person2 = new Form("Pedrinho", 13);

        Form.AverageAge(person1, person2);
    }
}