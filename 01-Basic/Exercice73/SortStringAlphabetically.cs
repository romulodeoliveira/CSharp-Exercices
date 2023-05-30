namespace Exercice73
{
    public class SortStringAlphabetically
    {
        public static string Alpha(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }
    }
}