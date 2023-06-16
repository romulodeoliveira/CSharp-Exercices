namespace Exercice01;

public class RandomNumberGenerator
{
    private Random _random;

    public RandomNumberGenerator()
    {
        _random = new Random();
    }

    public int GenerateRandomNumbers()
    {
        int randomNumber;
        randomNumber = _random.Next(1000, 9999);

        return randomNumber;
    }
}