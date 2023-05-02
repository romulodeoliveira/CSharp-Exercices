using System;

/*
Escreva um programa C# para verificar se uma determinada string começa com "w" e imediatamente seguida por dois "ww".
Dados de teste:
Insira uma string: www
Sample Output
False
*/

namespace Exercice43
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite uma frase: ");
            string str = Console.ReadLine();
            string test = "w";

            if (str[0] == 'w')
            {
                if (str[1] == 'w' && str[2] == 'w')
                {
                    System.Console.WriteLine("Verdadeiro");
                }

                else
                {
                    System.Console.WriteLine("Falso");
                }
            }

            else
            {
                System.Console.WriteLine("Falso");
            }
        }
    }
}

/*
Em C#, aspas simples (') são usadas para definir um caractere (por exemplo, 'a') e aspas duplas (") são usadas para definir uma string (por exemplo, "Olá").
*/