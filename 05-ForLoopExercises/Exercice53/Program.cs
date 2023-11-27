/*
Escreva um programa em C# Sharp para converter um número binário em octal.
Dados de teste:
Insira um número binário: 1001
Saída esperada :
O número binário: 1001
O número octal equivalente: 11
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insira um número binário: ");
        string numeroBinario = Console.ReadLine();

        if (EhBinarioValido(numeroBinario))
        {
            string numeroOctal = BinarioParaOctal(numeroBinario);

            Console.WriteLine($"O número binário: {numeroBinario}");
            Console.WriteLine($"O número octal equivalente: {numeroOctal}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir um número binário válido.");
        }
    }

    // Função para verificar se a string contém apenas 0s e 1s
    static bool EhBinarioValido(string numeroBinario)
    {
        foreach (char digito in numeroBinario)
        {
            if (digito != '0' && digito != '1')
            {
                return false;
            }
        }
        return true;
    }

    // Função para converter número binário para octal
    static string BinarioParaOctal(string numeroBinario)
    {
        while (numeroBinario.Length % 3 != 0)
        {
            numeroBinario = '0' + numeroBinario;
        }

        string numeroOctal = "";
        for (int i = 0; i < numeroBinario.Length; i += 3)
        {
            string grupoDeTres = numeroBinario.Substring(i, 3);
            int valorDecimal = Convert.ToInt32(grupoDeTres, 2);
            numeroOctal += Convert.ToString(valorDecimal, 8);
        }

        return numeroOctal;
    }
}
