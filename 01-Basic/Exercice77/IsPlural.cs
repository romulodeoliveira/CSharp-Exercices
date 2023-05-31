namespace Exercice77
{
    public class IsPlural
    {
        public static bool Word(string word)
        {
            if (word.EndsWith("s") || word.EndsWith("es"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}