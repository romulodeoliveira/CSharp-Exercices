using System;

/*
Escreva um programa C# para converter uma determinada string em letras minúsculas.

Saída de amostra:
escreva um programa nítido para exibir o seguinte padrão usando o alfabeto.
*/

namespace Exercice23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "O rato roeu a roupa do rei de Roma.";

            System.Console.WriteLine(str.ToLower());
        }
    }
}