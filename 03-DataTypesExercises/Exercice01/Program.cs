using System;

/*
Escreva um programa C# Sharp que receba três letras como entrada e as exiba na ordem inversa.

Test Data
Digite a letra: b
Digite a letra: a
Digite a letra: t
Saída esperada :
tab
*/

namespace Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = new string[] { "pão", "quejo", "presunto" };

            for (int i = values.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine(values[i]);
            }
        }
    }
}