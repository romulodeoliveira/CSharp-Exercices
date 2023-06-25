namespace Exercice93;

public class Math
{
    public static int SquareRoot(int number)
    {
        int guess = number / 2;
        int quotient = number / guess;

        while (guess > quotient)
        {
            guess = (guess + quotient) / 2;
            quotient = number / guess;
        }

        return guess;
    }
}