using System;

/*
Escreva um programa C# para verificar se o comprimento de uma determinada string é par ou ímpar. Retorne 'Comprimento ímpar' se o comprimento da string for ímpar, caso contrário, 'Comprimento par'.

Exemplo de saída:

String original: PHP
Converter as letras da string em ordem alfabética: Comprimento ímpar

String original: javascript
Converter as letras da string em ordem alfabética: Comprimento par

String original: python
Converter as letras do dita string em ordem alfabética: Mesmo comprimento
*/

namespace Exercice74
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "teste";

            System.Console.WriteLine(IsOddOrEven.LengthOddOrEven(str1));
        }
    }
}
