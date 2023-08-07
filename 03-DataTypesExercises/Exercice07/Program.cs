using System;

/*
Escreva um programa em C# Sharp que tome distância e tempo como entrada e exiba a velocidade em quilômetros por hora e milhas por hora.

Dados de teste:
Distância de entrada (metros): 50000
Tempo de entradaSec(hora): 1
Tempo de entradaSec(minutos): 35
Tempo de entradaSeg(segundos): 56
Saída esperada:
Sua velocidade em metros/s é 8,686588
Sua velocidade em km /h é 31,27172
Sua velocidade em milhas/h é 19,4355
*/

namespace Exercice07;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Distância de entrada (metros): ");
        double distanceMeters = double.Parse(Console.ReadLine());

        Console.Write("Tempo de entrada (horas): ");
        double timeHours = double.Parse(Console.ReadLine());

        Console.Write("Tempo de entrada (minutos): ");
        double timeMinutes = double.Parse(Console.ReadLine());

        Console.Write("Tempo de entrada (segundos): ");
        double timeSeconds = double.Parse(Console.ReadLine());

        double totalTimeHours = timeHours + timeMinutes / 60 + timeSeconds / 3600;
        double speedMetersPerSecond = distanceMeters / totalTimeHours;
        double speedKmPerHour = speedMetersPerSecond * 3.6;
        double speedMilesPerHour = speedKmPerHour / 1.60934;

        Console.WriteLine($"Sua velocidade em metros/s é {speedMetersPerSecond:F6}");
        Console.WriteLine($"Sua velocidade em km/h é {speedKmPerHour:F6}");
        Console.WriteLine($"Sua velocidade em milhas/h é {speedMilesPerHour:F6}");
    }
}