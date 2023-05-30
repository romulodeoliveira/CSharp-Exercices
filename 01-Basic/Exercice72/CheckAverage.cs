namespace Exercice72
{
    public class CheckAverage
    {
        public static bool CheckAverageInteger(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            double average = (double)sum / nums.Length;

            return average % 1 == 0;
        }
    }
}