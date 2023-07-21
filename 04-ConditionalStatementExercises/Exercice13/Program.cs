using System;

/*
Escreva um programa C# Sharp para ler a temperatura em graus centígrados e exibir uma mensagem adequada de acordo com o estado de temperatura abaixo:
Temp < 0, em seguida, Tempo de congelamento
Temp 0-10, em seguida, Tempo muito frio
Temp 10-20, em seguida, Tempo frio
Temp 20 -30, em seguida, Normal em Temp
Temp 30-40, em seguida, sua temperatura quente
>=40, em seguida, seus dados de teste muito quentes: 42

Saída esperada :
está muito quente.
*/

namespace Exercice13;

class Program
{
    static void Main(string[] args)
    {
        double temperature;
        Console.Write("Digite a temperatura em graus centígrados: ");
        if (double.TryParse(Console.ReadLine(), out temperature))
        {
            string message;
            if (temperature < 0)
            {
                message = "Tempo de congelamento";
            }
            else if (temperature >= 0 && temperature <= 10)
            {
                message = "Tempo muito frio";
            }
            else if (temperature > 10 && temperature <= 20)
            {
                message = "Tempo frio";
            }
            else if (temperature > 20 && temperature <= 30)
            {
                message = "Normal em Temp";
            }
            else if (temperature > 30 && temperature <= 40)
            {
                message = "Sua temperatura quente";
            }
            else
            {
                message = $"Seus dados de teste muito quentes: {temperature}";
            }

            Console.WriteLine($"A temperatura está {message}.");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um valor numérico válido.");
        }
    }
}

