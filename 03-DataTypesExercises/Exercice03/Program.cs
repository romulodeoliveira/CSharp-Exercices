using System;

// Escreva um programa C# Sharp que receba o ID do usuário e a senha como entrada (tipo string). Após 3 tentativas erradas, o usuário será rejeitado.

namespace Exercice03;

class Program
{
    static void Main(string[] args)
    {
        string idCorreto = "usuario";
        string senhaCorreta = "senha";
        int maxTentativas = 3;
        int tentativas = 0;

        while (tentativas < maxTentativas)
        {
            Console.Write("Digite o ID do usuário: ");
            string id = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string senha = Console.ReadLine();

            if (id == idCorreto && senha == senhaCorreta)
            {
                Console.WriteLine("Login bem-sucedido!");
                break;
            }
            else
            {
                Console.WriteLine("ID do usuário ou senha incorretos. Tente novamente.");
                tentativas++;
            }
        }

        if (tentativas == maxTentativas)
        {
            Console.WriteLine("Número máximo de tentativas excedido. Acesso negado.");
        }
    }
}
