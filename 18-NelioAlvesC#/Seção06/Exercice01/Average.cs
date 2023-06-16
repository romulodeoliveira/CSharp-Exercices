namespace Exercice01;

public class Average
{
    public double Height(int a, double[] b)
    {
        double sum = 0;
        for (int i = 0; i < a; i++)
        {
            sum += b[i];
        }

        double average = sum / a;
        return average;
    }
}