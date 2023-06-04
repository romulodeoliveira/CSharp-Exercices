using System;

/*
Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

Exemplo:

Entrada:
2200

Saída:
Senha Invalida

Entrada:
1020

Saída:
Senha Invalida

Entrada:
2022

Saída:
Senha Invalida

Entrada:
2002

Saída:
Acesso Permitido
*/

namespace  Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;
            int senhaDigitada;

            do
            {
                Console.WriteLine("Digite a senha:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out senhaDigitada))
                {
                    if (senhaDigitada == senhaCorreta)
                    {
                        Console.WriteLine("Acesso Permitido");
                        break; // Encerra o loop quando a senha é correta
                    }
                    else
                    {
                        Console.WriteLine("Senha Inválida");
                    }
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
