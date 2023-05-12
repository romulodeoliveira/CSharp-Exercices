/*
Escreva um programa C# Sharp para remover o caractere em uma determinada posição de uma determinada string. A posição dada estará no intervalo 0.. comprimento da string -1 inclusive.

Exemplo de entrada :
"Python", 1
"Python", o
"Python", 4

Saída esperada :
Pthon
ainda
Pythn
*/

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "CSharp";

            int num = int.Parse(Console.ReadLine());

            string newStr = str.Remove(num, 1);

            System.Console.WriteLine(newStr);
        }
    }
}