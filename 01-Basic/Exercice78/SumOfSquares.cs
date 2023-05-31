namespace Exercice78
{
    public class SumOfSquares
    {
        public static int Arrays(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum += num * num;
            }

            return sum;
        }
    }
}